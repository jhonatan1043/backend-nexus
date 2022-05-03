using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testnexus.Entitys;
using System.Collections.Generic;
using testnexus.Context;

namespace testnexus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly ContextBook _contextBook;
        public AutorController(ContextBook contextBook)
        {
            _contextBook = contextBook;
        }

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get()
        {
            return await _contextBook.Autores.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult> Post(Autor autor)
        {
            _contextBook.Autores.Add(autor);
             await _contextBook.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Autor autor, int id)
        {
            if (autor.Id != id)
            {
                return BadRequest("El id no corresponde a ningun autor");
            }

            _contextBook.Autores.Update(autor);
            await _contextBook.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await _contextBook.Autores.AnyAsync(x => x.Id == id);

            if (!exists)
            {
                return NotFound();
            }

            _contextBook.Autores.Remove(new Autor() { Id = id });
            await _contextBook.SaveChangesAsync();
            return Ok();
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using testnexus.Context;
using testnexus.Entitys;

namespace testnexus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialController : ControllerBase
    {     
        private readonly ContextBook _contextBook;
        public EditorialController(ContextBook contextBook)
        {
            _contextBook = contextBook;
        }

        [HttpGet]
        public async Task<ActionResult<List<Editorial>>> Get()
        {
            return await _contextBook.Editorials.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult> Post(Editorial editorial)
        {
            _contextBook.Editorials.Add(editorial);
            await _contextBook.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Editorial editorial, int id)
        {
            if (editorial.Id != id)
            {
                return BadRequest("El id no corresponde a ninguna editorial");
            }

            _contextBook.Editorials.Update(editorial);
            await _contextBook.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await _contextBook.Editorials.AnyAsync(x => x.Id == id);

            if (!exists)
            {
                return NotFound();
            }

            _contextBook.Editorials.Remove(new Editorial() { Id = id });
            await _contextBook.SaveChangesAsync();
            return Ok();
        }
    }
}

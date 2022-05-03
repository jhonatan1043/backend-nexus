using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testnexus.Context;
using testnexus.Entitys;

namespace testnexus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ContextBook _contextBook;
        public BookController(ContextBook contextBook)
        {
            _contextBook = contextBook;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get()
        {
            return  await _contextBook.books.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Book book)
        {
            var existsAutor = await _contextBook.Autores.AnyAsync(x => x.Id == book.Id);
            var existsEditorial = await _contextBook.Editorials.AnyAsync(x => x.Id == book.Id);

            if (existsAutor)
            {
                return BadRequest("el autor no existe");
            }

            if (existsEditorial)
            {
                return BadRequest("la editorial no existe");
            }

           /* if (ValidReg(book.IdEditorial))
            {
                return BadRequest("la editorial llego al nivel maximo de registro");
            }*/

            _contextBook.books.Add(book);
            await _contextBook.SaveChangesAsync();
            return Ok();
        }

        private bool ValidReg(int IdEditorial)
        {
            string max = _contextBook.Editorials.
                         Select(x => new { Id = x.Id, MaxBookReg = x.MaxBookReg }).
                         Where(x => x.Id == IdEditorial).Select(x => x.MaxBookReg).ToString();

            int count = _contextBook.books.Where(x => x.IdEditorial == IdEditorial).Count();

            return int.Parse(max) >= count;
        }
    }
}

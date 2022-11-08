using Microsoft.EntityFrameworkCore;
using WebAPI1.DATA;

namespace WebAPI1.repository
{
    public class Employee :IEmployee
    {
         public BooksContext _context;

        public  Employee(BooksContext context)
        {
            _context = context;
        }

        public async Task<List<BooksModel>> getAllBooks()
        {
            var result = await _context.Books.Select(x => new BooksModel()
            {
                Id = x.Id,

                Title = x.Title
            }
            ).ToListAsync();

            return result;
        }
    }
}

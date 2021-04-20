using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_Test.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookList_Test.Pages.BookList
{
    public class indexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public indexModel(ApplicationDbContext db)
        {
            _db = db;
            //extract the application DbContext is inside the dependency injection container and inject it onto this page
        }
        //Next, return a list of book

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
            //not using void method and change it to async method Task
        {
            Books = await _db.Book.ToListAsync();
            //assign this Books from the database (entity framework)
            //use "await"
            //Async method let you run multiple tasks at a time until it is awaited
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await _db.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                _db.Book.Remove(book);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
        }
    }
}
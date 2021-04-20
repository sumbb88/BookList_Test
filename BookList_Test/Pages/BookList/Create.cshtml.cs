using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_Test.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_Test.Pages.BookList
{
    public class CreateModel : PageModel
    {
        //only displany the text box for the user to input the info
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
                //The required input info will be the Book Name as I set in the Book.cs Page
            {
                await _db.Book.AddAsync(Book);
                //remember to add into the database, now it was quened
                await _db.SaveChangesAsync();
                //when this command is executed then the data will be record and push to the database
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
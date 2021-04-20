using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList_Test.Model
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        //ctor - Constructor TAB twice 
        //this will have to pass to the base
        //this is an empty contructor but the parameter is needed for dependency injection
        {

        }
        public DbSet<Book> Book { get; set; }
        //Next, add the book model to the database; need an entry
        //After the type and model add, now is going to add the DbContext inside the Startup.cs
    }
}

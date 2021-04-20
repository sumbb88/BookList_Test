using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList_Test.Model
{
    public class Book
    {
        [Key]
        //set up the auto read in

        public int id { get; set; }

        [Required]
        //want to display the book name, it required the user to input the data

        public string Name { get; set; }
        public string Author { get; set; }
        //put"prop" and hit TAB twice it will automatically create a property, then change the property into the object name
        public string ISBN { get; set; }
        //can be edit everytime if we need a new id
        //after add the new id, need to go to "Tools-> package Manager Console-> (do the new migration)
        //Always try to name the migration
    }
}

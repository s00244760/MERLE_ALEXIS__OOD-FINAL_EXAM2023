using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERLE_ALEXIS__OOD_FINAL_EXAM2023
{
    //Start Movie class
    public class Movie
    {
        //properties
        public int MovieID { get; set; }
        
        public string Title { get; set; }

        public string ImageName { get; set; }

        public string Description { get; set; }

        public string Cast { get; set; }

        // overried string method

        public override string ToString()
        {
            return Title; 
        }
    }// end of class movie 

    //data class
    public class MovieData : DbContext
    {
        public MovieData() : base("OODEXAM_AlexisMerle") { }

        public DbSet<Movie> Movies { get; set; }

    }
}

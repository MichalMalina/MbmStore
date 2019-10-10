using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
      
        private short released;
        private string imageUrl;
        private string director;

        public string Director
        {
            set { director = value; }
            get { return director; }
        }
        public short Released {get;set;}
        public string ImageUrl { get; set; } 

        public Movie ( int productID, string director , short released , string title , decimal price) :base(productID ,title , price)
        {
            this.Released = released;
            ImageUrl = imageUrl;
            this.Director = director;
        }
    }
}
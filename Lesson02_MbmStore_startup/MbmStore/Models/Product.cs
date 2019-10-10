using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;

namespace MbmStore.Models
{

 

   

    public class Product
    {

        public string title;
        public decimal price;
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl
        {get; set;}

        public int ProductID { get; set; }

        public Product () { }
        public Product(int productID , string title, decimal price)
        {
            ProductID = productID;
            Title = title;
            Price = price;
        }
    }


    
    

    
}

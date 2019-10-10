using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            // create a new Movie object with instance name jungleBook
           Customer customerOne = new Customer (1 ,"Mato", "Zeleny", "Mato", "Mato", "Mato"); 
            Customer customerTwo = new Customer (2 , "Smato" , "Neadnrtal", "Mato", "Mato", "Mato");
            Customer customerThree = new Customer (3 ,"Gladiator", "Pablo", "Mato", "Mato", "Mato");
            addPhone phoneone = new addPhone("0930439 , 39489384 , 099350935 , 5398589385");

         

            // assign a viewbag property to the new Movie object
            ViewBag.one = customerOne;
            ViewBag.two = customerTwo;
            ViewBag.three = customerThree;
            ViewBag.phoneone = phoneone;
            return View();



           
        }
    }
}
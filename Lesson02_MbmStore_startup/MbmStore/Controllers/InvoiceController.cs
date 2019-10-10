using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {

        [HttpPost]
        public IActionResult Index(int? customer)
        {
            List<SelectListItem> customers = new List<SelectListItem>();
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();



            foreach (Invoice invoice in Repository.Invoices)
            {

               


                if (invoice.Customer.CustomerId == customer )
                {
                    customers.Add(new SelectListItem
                    {

                        Text = invoice.Customer.Firstname + "" +
                  invoice.Customer.Lastname,
                        Value = invoice.Customer.CustomerId.ToString(),
                        Selected = true



                    });

                }

                else
                {
                    customers.Add(new SelectListItem
                    {

                        Text = invoice.Customer.Firstname + "" +
             invoice.Customer.Lastname,
                        Value = invoice.Customer.CustomerId.ToString(),
                        



                    });

                }


            }

          

            ViewData["Customers"] = customers;



            ViewBag.Invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == customer).ToList(); ;
            return View();
        }


        public IActionResult Index()
        {

        

            List<SelectListItem> customers = new List<SelectListItem>();
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            foreach (Invoice invoice in Repository.Invoices )
            {


                customers.Add(new SelectListItem
                {
                   
                Text = invoice.Customer.Firstname + "" +
                    invoice.Customer.Lastname,
                    Value = invoice.Customer.CustomerId.ToString()


                    

            });
            }

            ViewData["Customers"] = customers;

            ViewBag.Invoices = Repository.Invoices;
            return View();
        }
    }
}
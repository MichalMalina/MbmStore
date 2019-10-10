using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        public DateTime birthDate;
        public string firstnavn;
        public string lastnavn;
        public string address;
        public string zip;
        public string city;
        public string phone;
        public string age;
        public int customerid;
        public List<string> PhoneNumbers { get; } = new List<string>();
   

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int CustomerId { get; set; }

        public DateTime BirthDate
        {
            set
            {
                if (value > DateTime.Today.AddYears(-2))
                {
                    throw new Exception("At least one of the customers is too young");
                }
                if (value < DateTime.Today.AddYears(-120))
                {
                    throw new Exception("At least one of the customers is too old");
                }
                else
                {
                    birthDate = value;
                }
            }
            get { return birthDate; }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            }

        }

        public List<Invoice> Invoices
        {
            get; set;
        }

       

        public Customer(int customerid , string firstnavn, string lastnavn, string address, string zip, string city)
        {
            Firstname = firstnavn;
            Lastname = lastnavn;
            Adress = address;
            Zip = zip;
            City = city;
            CustomerId = customerid;


        }


        public void AddPhoneNumber(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }


    }

       
    


    public class addPhone
    {

        public List<string> PhoneNumbers { get; } = new List<string>();

        public  addPhone (string phone)
        {
            string.Join(", ", PhoneNumbers);

        }

    }

   


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models

{
    static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();

        static Repository() {

          
            List<MusicCD> musicCDs = new List<MusicCD>();
            List<Book> books = new List<Book>();
            List<Movie> movie = new List<Movie>();

            Book book = new Book( 1 ,"Hello Kitty", "Manga", 15, 12 , "ROMA", "0493090349")
            {

                ImageUrl = "gladiator.jpg"
            };
            Products.Add(book);


            Book book1 = new Book(2 ,"Paul Anderson", "Radiance", 15, 1812 , "Gimmy Scala" , "9439489")
            {

                ImageUrl = "JungleBook.jpg"
            };
            Products.Add(book1);

            MusicCD music2 = new MusicCD(3, "Seven Eleven", "Tron Gram", 2006, 300, "Havengrad");
            MusicCD music1 = new MusicCD(4,"Mango Master", "Jon Ben", 2016, 200 , "Kosco")
            {

                ImageUrl = "forrest-gump.jpg"
            };
            Products.Add(music1);



            Movie movie1 = new Movie(5, "Amradilo Sacharevsky", 1999, "Goosebumps", 1000)

            {

                ImageUrl = "lord.jpg"
            };
            Products.Add(movie1);

            movie.Add(movie1);
            books.Add(book);
            books.Add(book1);
            musicCDs.Add(music1);
            
            //IEnumerable<MusicCD> musicCDs = new List<MusicCD>();
            //List<string> tracks = new List<string>();
            //tracks.Add("Skinnus");
            //tracks.Add("Biggus");
            //tracks.Add("Chad");

            music1.AddTrack(new Tracks("Good Riddance", "Ben", new TimeSpan(0, 03, 44)));
            music1.AddTrack(new Tracks("Hello Prison", "Jon", new TimeSpan(0, 10, 44)));
            music1.AddTrack(new Tracks("Nights Out", "Ben", new TimeSpan(0, 03, 44)));
            music1.AddTrack(new Tracks("Lights Before", "Jon", new TimeSpan(0, 10, 44)));
            music1.AddTrack(new Tracks("Selection", "Ben", new TimeSpan(0, 03, 44)));

            Customer cust1 = new Customer( 1 ,"Michal", "Malina", "Bangds 10", "8000", "Aarhus A");
            cust1.AddPhoneNumber("75894375");
            cust1.AddPhoneNumber("543543534");
            cust1.BirthDate = new DateTime(1990, 9, 06);

            Customer cust2 = new Customer( 2 , "Hellman", "Bracher", "Dansely", "54321", "Dallas");
            cust2.AddPhoneNumber("85594358");
            cust2.BirthDate = new DateTime(2000, 01, 12);

            Invoice inv1 = new Invoice(1, new DateTime(2019, 09, 04), cust1);
            inv1.AddOrderItem(book, 1);
            inv1.AddOrderItem(movie1, 2);
            Invoices.Add(inv1);

            Invoice inv2 = new Invoice(2, new DateTime(2019, 09, 13), cust2);
            inv2.AddOrderItem(music1, 1);
            inv2.AddOrderItem(music2, 2);
            Invoices.Add(inv2);

            Product prd1 = new Product(1 ,"Gandlaf", 19);
            Product prd2 = new Product(2 , "Legolas", 19);
            Product prd3 = new Product(3 ,"Gimli", 19);
            Product prd4 = new Product(4 ,"Boromir", 19);
            Product prd5 = new Product(5 ,"Sauron", 19);



        }

    }
}

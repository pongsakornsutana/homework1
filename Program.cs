using System;
using System.Collections.Generic;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {


            User jame = new User("jame");
            jame.name = "jame watson";
            jame.email = "jame@gmail.com";

            TShirt shirt1 = new TShirt("L", "Red", 500);
            TShirt shirt2 = new TShirt("M", "Black", 750);
            TShirt shirt3 = new TShirt("M", "Black", 625);

            List<TShirt> OderTShirt = new List<TShirt>();

            jame.addlist(shirt1);
            jame.addlist(shirt2);
            jame.addlist(shirt3);

            Address youraddress = new Address();
            Console.WriteLine("Street :" + youraddress.street);
            Console.WriteLine("City :" + youraddress.City);
            Console.WriteLine("Zipcode :" + youraddress.zipCode);
            jame.getShoppingCart();

            

        }
    }
    class TShirt
    {

        public string size;
        public string color;
        public float price;

        public TShirt(string valuesize, string valuecolor, float valueprice)
        {
            size = valuesize;
            color = valuecolor;
            price = valueprice;
        }

    }
    class ShoppingCart {

        private List<TShirt> OderTShirt = new List<TShirt>();

      
       
    }
    class User
    {
        public string name;

        public string email;

        private List<TShirt> OderTShirt = new List<TShirt>();

        public User(string valueName)
        {

            OderTShirt = new List<TShirt>();
        }
        public void addlist(TShirt shirt)
        {
            OderTShirt.Add(shirt);

        }

        public void getShoppingCart()
        {
            float i = 0;
            foreach (TShirt item in OderTShirt)
            {
                i = i+item.price;   
            }
            Console.WriteLine(i);

        }

    }
    class Address
    {
        public string street;

        public string City;

        public string zipCode;

        public Address()
        {

            street = "131/75,Phutthamonthon";
            City = "Nakron Prethom";
            zipCode = "10180";

        }
    }
}
       
    


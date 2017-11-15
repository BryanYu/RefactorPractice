using System;
using System.Collections.Generic;
using System.Linq;
using RefatorPractice.Ch1Lab;

namespace RefatorPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customer = new Customer("Bryan");
            var rental = new Rental(new Movie("Movie1", 0), 2);
            customer.AddRental(rental);
            var result = customer.GetStatement();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
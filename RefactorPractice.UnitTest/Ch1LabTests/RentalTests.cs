using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RefatorPractice.Ch1Lab;

namespace RefactorPractice.UnitTest.Ch1LabTests
{
    [TestFixture]
    public class RentalTests
    {
        [Test]
        public void When_Customer_Add_Rental_Get_Statement()
        {
            var customer = new Customer("Bryan");
            var rental = new Rental(new Movie("Movie1", 0), 2);
            customer.AddRental(rental);
            var actual = customer.GetStatement();
            var expected = @"Rental Record forBryan Movie1 2 Amount owed is 2 You earned 1 frequent renter points";
            StringAssert.AreEqualIgnoringCase(expected, actual);
        }
    }
}
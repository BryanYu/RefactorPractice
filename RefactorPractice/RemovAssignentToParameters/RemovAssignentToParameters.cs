using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.RemovAssignentToParameters
{
    public class RemovAssignentToParameters
    {
        public int Discount(int inputVal, int quantity, int yearToDate)
        {
            int result = inputVal;
            if (inputVal > 50)
            {
                result -= 2;
            }

            if (quantity > 100)
            {
                result -= 1;
            }

            if (yearToDate > 10000)
            {
                result -= 4;
            }
            return result;
        }
    }
}
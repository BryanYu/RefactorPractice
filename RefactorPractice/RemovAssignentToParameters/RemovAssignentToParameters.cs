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
            if (inputVal > 50)
            {
                inputVal -= 2;
            }

            if (quantity > 100)
            {
                inputVal -= 1;
            }

            if (yearToDate > 10000)
            {
                inputVal -= 4;
            }

            return inputVal;
        }
    }
}
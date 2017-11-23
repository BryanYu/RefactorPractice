using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.ReplaceMethodWithMethodObject
{
    public class ReplaceMethodWithMethodObject
    {
        public class Account
        {
            public int Gamma(int inputVal, int quantity, int yearToDate)
            {
                return new Gamma(this, inputVal, quantity, yearToDate).Compute();
            }

            public int Delta()
            {
                return 0;
            }
        }

        public class Gamma
        {
            private Account _account;

            private int inputVal;

            private int quantity;

            private int yearToDate;

            private int importantValue1;

            private int importantValue2;

            private int importantValue3;

            public Gamma(Account source, int inputValArg, int quantityArg, int yearToDateArg)
            {
                this._account = source;
                this.inputVal = inputValArg;
                this.quantity = quantityArg;
                this.yearToDate = yearToDateArg;
            }

            public int Compute()
            {
                int importantValue1 = (inputVal * quantity) + this._account.Delta();
                int importantValue2 = (inputVal * yearToDate) + 100;
                this.ImportantThing();
                int importantValue3 = importantValue2 * 7;
                return importantValue3 - 2 * importantValue1;
            }

            private void ImportantThing()
            {
                if ((yearToDate - importantValue1) > 100)
                {
                    importantValue2 -= 20;
                }
            }
        }
    }
}
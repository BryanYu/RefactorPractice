using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ChangeReferenceToValue
{
    public class ChangeReferenceToValue
    {
        private void Sample()
        {
            var instance = Activator.CreateInstance(typeof(Currency), "USD");
        }

        public class Currency
        {
            private string Code { get; set; }

            private Currency(string code)
            {
                this.Code = code;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Currency))
                {
                    return false;
                }
                return Code.Equals(((Currency)obj).Code);
            }

            public override int GetHashCode()
            {
                return Code.GetHashCode();
            }
        }
    }
}
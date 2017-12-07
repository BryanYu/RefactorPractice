using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.SeparateQueryFromModifier
{
    internal class SeparateQueryFromModifier
    {
        public void CheckSecurity(string[] people)
        {
            string found = this.FoundMiscreant(people);
            SomeLaterCode(found);
        }

        private void SomeLaterCode(string found)
        {
            throw new NotImplementedException();
        }

        public string FoundMiscreant(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    return "Don";
                }
                if (people[i].Equals("John"))
                {
                    SendAlert();
                    return "John";
                }
            }
            return "";
        }

        private void SendAlert()
        {
            throw new NotImplementedException();
        }
    }
}
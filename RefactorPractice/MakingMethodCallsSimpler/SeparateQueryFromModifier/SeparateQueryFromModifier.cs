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
            this.SendAlert(people);
            string found = FoundPerson(people);
            SomeLaterCode(found);
        }

        private void SomeLaterCode(string found)
        {
            throw new NotImplementedException();
        }

        public void SendAlert(string[] people)
        {
            if (!FoundPerson(people).Equals(""))
            {
                this.SendAlert();
            }
        }

        public string FoundPerson(string[] people)
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
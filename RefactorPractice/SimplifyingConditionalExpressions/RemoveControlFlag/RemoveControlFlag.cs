using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.SimplifyingConditionalExpressions.RemoveControlFlag
{
    internal class RemoveControlFlag
    {
        public class WithBreak
        {
            private void CheckSecurity(string[] people)
            {
                for (int i = 0; i < people.Length; i++)
                {
                    if (people[i].Equals("Don"))
                    {
                        SendAlert();
                        break;
                    }
                    if (people[i].Equals("John"))
                    {
                        SendAlert();
                        break;
                    }
                }
            }

            private void SendAlert()
            {
                throw new NotImplementedException();
            }
        }

        public class WithReturn
        {
            private void CheckSecurity(string[] people)
            {
                var found = FoundMiscreant(people);
                SomeLaterCode(found);
            }

            private string FoundMiscreant(string[] people)
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

            private void SomeLaterCode(string found)
            {
                throw new NotImplementedException();
            }

            private void SendAlert()
            {
                throw new NotImplementedException();
            }
        }
    }
}
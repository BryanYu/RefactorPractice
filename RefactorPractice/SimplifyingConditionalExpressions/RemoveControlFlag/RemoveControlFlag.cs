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
                var found = "";
                for (int i = 0; i < people.Length; i++)
                {
                    if (found.Equals(""))
                    {
                        if (people[i].Equals("Don"))
                        {
                            SendAlert();
                            found = "Don";
                        }
                        if (people[i].Equals("John"))
                        {
                            SendAlert();
                            found = "John";
                        }
                    }
                }
                SomeLaterCode(found);
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
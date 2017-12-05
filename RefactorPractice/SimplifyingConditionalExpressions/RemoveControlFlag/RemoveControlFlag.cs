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
                bool found = false;
                for (int i = 0; i < people.Length; i++)
                {
                    if (!found)
                    {
                        if (people[i].Equals("Don"))
                        {
                            SendAlert();
                            found = true;
                        }
                        if (people[i].Equals("John"))
                        {
                            SendAlert();
                            found = true;
                        }
                    }
                }
            }

            private void SendAlert()
            {
                throw new NotImplementedException();
            }
        }
    }
}
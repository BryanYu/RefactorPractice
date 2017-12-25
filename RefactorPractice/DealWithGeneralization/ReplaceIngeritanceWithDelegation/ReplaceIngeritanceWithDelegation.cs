using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.ReplaceIngeritanceWithDelegation
{
    internal class ReplaceIngeritanceWithDelegation
    {
        public class MyStack : ArrayList
        {
            public void Push(Object obj)
            {
                base.Insert(0, obj);
            }

            public Object Pop()
            {
                var result = base[0];
                base.RemoveAt(0);
                return result;
            }
        }
    }
}
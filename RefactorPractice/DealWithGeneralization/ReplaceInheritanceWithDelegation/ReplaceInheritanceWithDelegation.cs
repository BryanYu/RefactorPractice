using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.ReplaceIngeritanceWithDelegation
{
    internal class ReplaceInheritanceWithDelegation
    {
        public class MyStack
        {
            private ArrayList _arrayList;

            public void Push(Object obj)
            {
                this._arrayList.Insert(0, obj);
            }

            public Object Pop()
            {
                var result = this._arrayList[0];
                this._arrayList.RemoveAt(0);
                return result;
            }

            public int Size()
            {
                return this._arrayList.Count;
            }

            public bool IsEmpty()
            {
                return this._arrayList.Count == 0;
            }
        }
    }
}
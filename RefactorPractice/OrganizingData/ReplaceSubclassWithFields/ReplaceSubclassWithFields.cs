using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceSubclassWithFields
{
    internal class ReplaceSubclassWithFields
    {
        public abstract class Person
        {
            public abstract bool IsMale();

            public abstract char GetCode();
        }

        public class Male : Person
        {
            public override bool IsMale()
            {
                return true;
            }

            public override char GetCode()
            {
                return 'M';
            }
        }

        public class Female : Person
        {
            public override bool IsMale()
            {
                return false;
            }

            public override char GetCode()
            {
                return 'F';
            }
        }
    }
}
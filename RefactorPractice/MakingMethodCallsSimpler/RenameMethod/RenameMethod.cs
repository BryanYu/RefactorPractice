using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.RenameMethod
{
    public class RenameMethod
    {
        private string _officeNumber;

        private string _officeAreaCode;

        public string GetTelephoneNumber()
        {
            return $"({_officeAreaCode}){_officeNumber}";
        }
    }
}
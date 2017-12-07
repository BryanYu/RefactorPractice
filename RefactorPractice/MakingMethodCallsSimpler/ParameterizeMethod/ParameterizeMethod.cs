using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.ParameterizeMethod
{
    internal class ParameterizeMethod
    {
        private class Employee
        {
            protected double BaseCharge()
            {
                double result = Math.Min(LastUsage(), 100) * 0.03;
                if (LastUsage() > 100)
                {
                    result += (Math.Min(LastUsage(), 100) - 100) * 0.05;
                }
                if (LastUsage() > 200)
                {
                    result += (LastUsage() - 200) * 0.07;
                }
                return result;
            }

            private double LastUsage()
            {
                throw new NotImplementedException();
            }
        }
    }
}
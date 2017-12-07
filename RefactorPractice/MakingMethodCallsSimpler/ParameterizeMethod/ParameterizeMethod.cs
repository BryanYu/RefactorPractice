using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.ParameterizeMethod
{
    internal class ParameterizeMethod
    {
        private class Employee
        {
            protected double BaseCharge()
            {
                double result = UsageInRange(0, 100) * 0.03;
                result += UsageInRange(100, 200) * 0.05;
                result += UsageInRange(200, Int32.MaxValue) * 0.07;
                return result;
            }

            private double UsageInRange(int start, int end)
            {
                if (this.LastUsage() > start)
                {
                    return Math.Min(this.LastUsage(), end) - start;
                }
                return 0;
            }

            private double LastUsage()
            {
                throw new NotImplementedException();
            }
        }
    }
}
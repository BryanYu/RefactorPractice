using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceMagicNumberWithSymbolicConstant
{
    public class ReplaceMagicNumberWithSymbolicConstant
    {
        public double PotentialEnergy(double mass, double height)
        {
            return mass * 9.81 * height;
        }
    }
}
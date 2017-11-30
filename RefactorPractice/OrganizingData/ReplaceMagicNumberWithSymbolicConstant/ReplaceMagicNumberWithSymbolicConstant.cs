using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceMagicNumberWithSymbolicConstant
{
    public class ReplaceMagicNumberWithSymbolicConstant
    {
        public const double GRAVITATIONAL_CONSTANT = 9.81;

        public double PotentialEnergy(double mass, double height)
        {
            return mass * GRAVITATIONAL_CONSTANT * height;
        }
    }
}
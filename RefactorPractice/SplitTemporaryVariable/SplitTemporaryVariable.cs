using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.SplitTemporaryVarible
{
    public class SplitTemporaryVarible
    {
        private double _primaryForce;

        private double _mass;

        private int _delay;

        private double _secondaryForce;

        public double GetDistanceTravelled(int time)
        {
            double result;
            double primaryAcc = _primaryForce / _mass;
            int primaryTime = Math.Min(time, _delay);
            result = 0.5 * primaryAcc * primaryTime * primaryTime;
            int secondaryTime = time - this._delay;
            if (secondaryTime > 0)
            {
                double primaryVel = primaryAcc * this._delay;
                double secondaryAcc = (this._primaryForce + _secondaryForce) / this._mass;
                result += primaryVel * secondaryTime + 0.5 * secondaryAcc * secondaryTime * secondaryTime;
            }
            return result;
        }
    }
}
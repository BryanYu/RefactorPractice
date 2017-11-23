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
            double acc = _primaryForce / _mass;
            int primaryTime = Math.Min(time, _delay);
            result = 0.5 * acc * primaryTime * primaryTime;
            int secondaryTime = time - this._delay;
            if (secondaryTime > 0)
            {
                double primaryVel = acc * this._delay;
                acc = (this._primaryForce + _secondaryForce) / this._mass;
                result += primaryVel * secondaryTime + 0.5 * acc * secondaryTime * secondaryTime;
            }
            return result;
        }
    }
}
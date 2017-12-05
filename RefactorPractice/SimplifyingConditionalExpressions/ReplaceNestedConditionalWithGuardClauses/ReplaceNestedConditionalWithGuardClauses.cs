using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.SimplifyingConditionalExpressions.ReplaceNestedConditionalWithGuardClauses
{
    internal class ReplaceNestedConditionalWithGuardClauses
    {
        private bool _isDead;

        private bool _isSeparated;

        private bool _isRetired;

        public double GetPayAmount()
        {
            double result = 0.0;
            if (_isDead)
            {
                result = DeadAmount();
            }
            else
            {
                if (_isSeparated)
                {
                    result = SeparatedAmount();
                }
                else
                {
                    if (_isRetired)
                    {
                        result = RetiredAmount();
                    }
                    else
                    {
                        result = NormalPayAmount();
                    }
                }
            }
            return result;
        }

        private double NormalPayAmount()
        {
            throw new NotImplementedException();
        }

        private double RetiredAmount()
        {
            throw new NotImplementedException();
        }

        private double SeparatedAmount()
        {
            throw new NotImplementedException();
        }

        private double DeadAmount()
        {
            throw new NotImplementedException();
        }
    }
}
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
            if (_isDead)
            {
                return DeadAmount();
            }
            if (_isSeparated)
            {
                return SeparatedAmount();
            }
            if (_isRetired)
            {
                return RetiredAmount();
            }
            return NormalPayAmount();
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
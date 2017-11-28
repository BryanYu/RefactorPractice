using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceArrayWithObject
{
    public class ReplaceArrayWithObject
    {
        public void Sample()
        {
            Performance row = new Performance();
            row.Name = "Liverpool";
            row.Wins = 15;
            int wins = row.Wins;
        }

        public class Performance
        {
            public string Name { get; set; }

            public int Wins { get; set; }
        }
    }
}
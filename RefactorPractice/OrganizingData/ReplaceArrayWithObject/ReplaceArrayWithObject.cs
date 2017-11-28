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
            string[] row = new string[3];
            row[0] = "Liverpool";
            row[1] = "15";
            string name = row[0];
            int wins = Convert.ToInt32(name);
        }
    }
}
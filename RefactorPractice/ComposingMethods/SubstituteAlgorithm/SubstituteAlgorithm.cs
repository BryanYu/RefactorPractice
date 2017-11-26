using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorPractice.ComposingMethods.SubstituteAlgorithm
{
    public class SubstituteAlgorithm
    {
        public string FoundPerson(string[] people)
        {
            var candidates = new List<string> { "Don", "John", "Kent" };

            for (int i = 0; i < people.Length; i++)
            {
                if (candidates.Contains(people[i]))
                {
                    return people[i];
                }
            }

            return string.Empty;
        }
    }
}
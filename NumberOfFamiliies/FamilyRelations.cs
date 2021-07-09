using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberOfFamiliies
{
    class FamilyRelations
    {
        public int VerifyFamilies(List<Tuple<string, string>> relations)
        {
            return DistinctFamilies(relations);
        }

        private int DistinctFamilies(List<Tuple<string, string>> relations)
        {
            List<string> currentFamily = new List<string>();
            List<List<string>> groupedFamilies = new List<List<string>>();
            foreach (Tuple<string, string> T in relations)
            {
                if (currentFamily.Count == 0 || currentFamily.Contains(T.Item1) || currentFamily.Contains(T.Item2))
                {
                    currentFamily.Add(T.Item1);
                    currentFamily.Add(T.Item2);
                }
                else
                {
                    currentFamily.Sort();
                    groupedFamilies.Add(currentFamily.Distinct().ToList());
                    currentFamily = new List<string>();
                    currentFamily.Add(T.Item1);
                    currentFamily.Add(T.Item2);
                }
            }
            if (currentFamily.Count > 0)
            {
                currentFamily.Sort();
                groupedFamilies.Add(currentFamily.Distinct().ToList());
            }

            return groupedFamilies.Count;
        }
    }
}

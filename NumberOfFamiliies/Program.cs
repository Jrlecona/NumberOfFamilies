using System;
using System.Collections.Generic;

namespace NumberOfFamiliies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You're given a list of pairs that represent direct relationships between 2 persons. Each pair means that these persons are directly related. For example:");
            Console.WriteLine("  'john', 'jane'");
            Console.WriteLine("  'john', 'peter'");
            Console.WriteLine("  'john', 'samuel'");
            Console.WriteLine("  'peter', 'mark'");
            Console.WriteLine("  'mark', 'sasha'");
            Console.WriteLine("  'kirk', 'tom'");
            Console.WriteLine("  'tom', 'erica'");

            Console.WriteLine(" ");

            var tupleList = new List<Tuple<string, string>>
              {
                  Tuple.Create("A", "B"),
                  Tuple.Create("A", "C"),
                  Tuple.Create("A", "D"),
                  Tuple.Create("C", "E"),
                  Tuple.Create("F", "G"),
                  Tuple.Create("G", "H"),
                  Tuple.Create("I", "J"),
                  Tuple.Create("J", "K")
              };

            FamilyRelations obj = new FamilyRelations();

            var numberFamilies = obj.VerifyFamilies(tupleList);


            Console.WriteLine("Number of Families = {0}", numberFamilies);
        }

        

    }
}

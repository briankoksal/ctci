using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //implement an algorithm to determine if string has all unique characters

            Console.WriteLine(AllUniqueCharacters("hello"));
            Console.ReadLine();
        }

        private static bool AllUniqueCharacters(string value)
        {
            List<Char> characters = new List<char>();

            for (int x = 0; x < value.Count(); x++)
            {
                char cur = value.ElementAt(x);
                if (characters.Contains(cur))
                {
                    return false;
                }
                else {
                    characters.Add(cur);
                }
            }

            return true;
        }

    }
}

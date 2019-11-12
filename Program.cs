using System;
using System.Collections.Generic;
namespace rename
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> wawa = new List<int>();
            IHomework13 re = new homework2();
            var number = new List<int>(){000000, 000099, 009900, 990000,
            000999, 009990, 099900, 999000,
            990999, 919909, 999799, 999999,};
            wawa = re.Homework13(number);
            foreach (var item in wawa)
            {
                string r = String.Format("{0:D6}", item);
                Console.WriteLine(r);
            }

        }
    }
}
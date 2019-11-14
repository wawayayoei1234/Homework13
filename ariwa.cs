using System;
using System.Collections.Generic;
namespace rename
{
    class homework2 : IHomework13
    {
        public IEnumerable<int> Homework13(IEnumerable<int> numbers)
        {
            List<int> Result = new List<int>();
            foreach (var item in numbers)
            {
                int uturn = check1(item);
                if (uturn != 0)
                {
                    Result.Add(uturn);
                }
            }
            return Result;
        }
        public static int check1(int item)
        {
            string savenumcha = null;
            string numcheck = String.Format("{0:D6}", item);
            {
                var wawa = (ceck2(numcheck, 5, 4, 3))
                || (ceck1(numcheck, 0, 1, 2, 3))
                || (ceck1(numcheck, 1, 2, 3, 4))
                || (ceck1(numcheck, 2, 3, 4, 5))
                || (ceck2(numcheck, 0, 1, 2));
                if (wawa)
                {
                    foreach (var it in numcheck)
                    {
                        savenumcha += it;
                    }
                    int stot = int.Parse(savenumcha);
                    int sum = stot;
                    Console.WriteLine(sum);
                    return sum;
                }
                return 0;
            }
        }
        public static bool ceck1(string numcheck, int a, int b, int c, int d)
        {
            return (numcheck[a] != '9' && numcheck[b] == '9' && numcheck[c] == '9' && numcheck[d] != '9');
        }
        public static bool ceck2(string numcheck, int a, int b, int c)
        {
            return (numcheck[a] == '9' && numcheck[b] == '9' && numcheck[c] != '9');
        }
    }
}
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
            string r = String.Format("{0:D6}", item);
            char[] numcha = r.ToCharArray();
            {
                if (numcha[4] == '9'&& numcha[5]=='9')
                {
                    if (numcha[3] != '9')
                    {
                        foreach (var it in numcha)
                        {
                            savenumcha += it;
                        }
                        int stot = int.Parse(savenumcha);
                        int sum = stot;
                        return sum;
                    }
                }
            }
            if (numcha[4] == '9' && numcha[3] == '9')
            {
                if (numcha[5] != '9' && numcha[2] != '9')
                {

                    foreach (var it in numcha)
                    {
                        savenumcha += it;
                    }
                    int stot = int.Parse(savenumcha);
                    int sum = stot;
                    return sum;
                }
            }
            if (numcha[3] == '9' && numcha[2] == '9')
            {
                if (numcha[4] != '9' && numcha[1] != '9')
                {
                    foreach (var it in numcha)
                    {
                        savenumcha += it;
                    }
                    int stot = int.Parse(savenumcha);
                    int sum = stot;
                    return sum;
                }
            }
            if (numcha[2] == '9' && numcha[1] == '9')
            {
                if (numcha[3] != '9' && numcha[0] != '9')
                {
                    foreach (var it in numcha)
                    {
                        savenumcha += it;
                    }
                    int stot = int.Parse(savenumcha);
                    int sum = stot;
                    return sum;
                }
            }
            if (numcha[1] == '9' && numcha[0] == '9')
            {
                if (numcha[2] != '9')
                {
                    foreach (var it in numcha)
                    {
                        savenumcha += it;
                    }
                    int stot = int.Parse(savenumcha);
                    int sum = stot;
                    return sum;
                }
            }
            return 0;
        }
    }
}

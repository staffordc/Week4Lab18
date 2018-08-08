using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    static class CountingAlgorithm
    {
        //O(n^2)
        public static int[] CountWithArray(int[] input)
        {
            int MaxIntInArray = input.Max()+1;
            int[] TheCounter = new int[MaxIntInArray];
            foreach (int i in input)
            {
                TheCounter[i]++;
            }
            return TheCounter;
        }

        //O(n)
        public static Dictionary<int,int> CountWithDicionary(int[] input)
        {
            var TheCounter = new Dictionary<int, int>();
            foreach (int i in input)
            {
                if (TheCounter.ContainsKey(i))
                {
                    TheCounter[i]++;
                }
                else
                {
                    TheCounter.Add(i,1);
                }
            }
            return TheCounter;
        }
    }
}

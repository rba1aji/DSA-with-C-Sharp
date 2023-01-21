using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    internal class HashDataStructures
    {
        public void UseDictionary()
        {
            var d = new Dictionary<int, int>();
            int[] arr = { 1, 3, 4, 2, 2, 1, 4, 3, 2, 2, 4, 5 };
            foreach (int i in arr)
            {
                d[i] = d.GetValueOrDefault(i, 0) + 1;
            }
            foreach (KeyValuePair<int, int> i in d)
            {
                Console.WriteLine($"{i.Key} {i.Value}");
            }
        }

    }
}

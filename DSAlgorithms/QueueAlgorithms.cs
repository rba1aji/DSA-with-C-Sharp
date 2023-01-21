using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    internal class QueueAlgorithms
    {
        public int[] generateBinaryNumbers(int n)
        {
            int[] res = new int[n];
            var q = new Queue<int>();
            q.Enqueue(1);
            for (int i = 0; i < n; i++)
            {
                int peek = q.Dequeue();
                res[i] = peek;
                q.Enqueue(peek * 10);
                q.Enqueue((peek * 10) + 1);
            }
            return res;
        }
    }
}

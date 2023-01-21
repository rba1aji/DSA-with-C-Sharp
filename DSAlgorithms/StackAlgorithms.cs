using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    internal class StackAlgorithms
    {
        public void nextGreaterElements(int[] arr)
        {
            var st = new Stack<int>();
            st.Push(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];
                if (st.Count > 0)
                {
                    int popped = st.Pop();
                    while (popped < next)
                    {
                        Console.WriteLine($"{popped}-->{next}");
                        if (st.Count == 0) break;
                        popped = st.Pop();
                    }
                    if (popped > next)
                    {
                        st.Push(popped);
                    }
                }
                st.Push(next);
            }
            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop() + "-->-1");
            }
        }


        public Boolean isMatchedParanthesis(string str)
        {
            var st = new Stack<char>();
            foreach (char i in str)
            {
                if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z') continue;
                if (i == '(')
                {
                    st.Push(i);
                }
                else if (i == ')' && st.Count < 1) return false;
                else st.Pop();
            }
            return st.Count == 0;
        }

        public Boolean isMatchedParanthesis2(string str)
        {
            int tracker = 0;
            foreach (char i in str)
            {
                if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z') continue;
                if (i == '(')
                {
                    tracker++;
                }
                else if (i == ')' && tracker < 1) return false;
                else tracker--;
            }
            return tracker == 0;
        }



    }
}

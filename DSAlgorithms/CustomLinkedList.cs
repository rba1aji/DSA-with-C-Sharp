using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    public class CustomLinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public void add(int data)
        {
            //Console.WriteLine(head?.data + "   " + data);
            if (head == null) head = new Node(data);
            else
            {
                Node t = head;
                while (t.next != null)
                {
                    t = t.next;
                }
                t.next = new Node(data);
            }
        }

        public void Display()
        {
            Console.WriteLine("\nDisplaying");
            Node t = head;
            while (t != null)
            {
                Console.Write(t.data);
                t = t.next;
            }
        }

        public Node FindMid()
        {
            Node slow = head;
            Node fast = head;
            Node mid = head;
            while (fast != null && fast.next != null)
            {
                mid = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            Console.WriteLine($"slow{slow.data}fast{fast}");
            return mid;
        }
        public void RemoveBackHalf()
        {
            Node mid = FindMid();
            mid.next = null;
        }
 
        public void DeleteNodeByIndex(int index)
        {
            Node t = head;
            for (int i = 0; i < index - 2; i++)
            {
                Console.WriteLine(t.data+" -..-"+ (i+1));
                t = t.next;
            }
            t.next = t.next.next; 

        }

        internal void FormACycle(int a, int b)
        {
            Node an = head;
            for(int i = 1; i < a; i++)
            {
                an=an.next;
            }
            Node bn = head;
            for(int i=1;i<b;i++)
            {
                bn=bn.next;
            }
            bn.next = an;
            
        }

        internal bool hasCycle()
        {
            var hs = new HashSet<Node>();
            Node node= head;
            while (node != null)
            {
                if (!hs.Add(node)) return true;
                node = node.next;
            }
            return false;
        }
    }


}

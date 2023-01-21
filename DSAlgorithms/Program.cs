using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using DSAlgorithms;
using System.Collections.Generic;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("___Data Structure Algorithms___");

        var ob = new ArrayAlgorithms();

        int[] arr = ("1,2,3,4,5,6,7").Split(",").Select(int.Parse).ToArray();

        Console.WriteLine($"Linear Search: {ob.LinearSearch(arr, 1)}");
        Console.WriteLine($"Linear Search: {ob.LinearSearch2(arr, 1)}");
        Console.WriteLine($"Binary Search: {ob.BinarySearch(arr, 4)}");
        Console.WriteLine();

        Console.WriteLine("reverse array");
        ob.ReverseArray(ref arr);
        void cw(int i)
        {
            Console.Write(i + ",");
        }
        Array.ForEach(arr, cw);

        Console.WriteLine("\nRotate Array");
        ob.RotateArrayLeft(ref arr, 2);
        Array.ForEach(arr, Console.Write);



        Console.WriteLine("\n\n___LINKED LIST___");

        var ll = new CustomLinkedList();
        ll.add(1); ll.add(2); ll.add(3);
        ll.add(4); ll.add(5);
        ll.add(6); ll.add(7);

        ll.Display();

        Console.Write("\nDelete 4");
        ll.DeleteNodeByIndex(4);
        ll.Display();

        ll.RemoveBackHalf();
        ll.Display();

        //var li = new LinkedList<int>();
        //li.AddLast(1);
        //li.AddLast(2);
        //li.AddLast(3);
        //foreach (int node in li)
        //{
        //    Console.WriteLine(node);
        //}
        Console.WriteLine("\n");





        Console.WriteLine("___STACK QUEUE___");
        Console.WriteLine();

        var qa = new QueueAlgorithms();
        var bin = qa.generateBinaryNumbers(10);
        Console.WriteLine("BInary numbers");
        Array.ForEach(bin, Console.WriteLine);

        var st = new StackAlgorithms();
        Console.WriteLine("next greater elements in arr");
        st.nextGreaterElements(new int[] { 15, 8, 4, 10 });

        Console.WriteLine("paranthesis match");
        Console.WriteLine(
        st.isMatchedParanthesis("(HEllo))")
        + " " +
        st.isMatchedParanthesis("(HEl(l)o)")
        + " " +
        st.isMatchedParanthesis("(HEllo)")
        );

        Console.WriteLine(
        st.isMatchedParanthesis2("(HEl((l))o)")
        + " " + st.isMatchedParanthesis("(HEl(l)o)")
        + " " + st.isMatchedParanthesis("HEl(l)o)")
        );




        Console.WriteLine("\n___HASHSET, DICTIONARY___");

        ll = new CustomLinkedList();

        ll.add(1); ll.add(2); ll.add(3);
        ll.add(4); ll.add(5); ll.add(6);

        ll.FormACycle(2, 5);
        Console.WriteLine("Cycle" + ll.hasCycle());

        var h = new HashDataStructures();
        h.UseDictionary();




        Console.WriteLine("____TREE____");

        var bst = new BinarySearchTree();

        bst.Insert(2); bst.Insert(5); bst.Insert(1);
        bst.Insert(6); bst.Insert(3); bst.Insert(4);
        //    2
        //  1    5
        //~  3  4  6    
        bst.InOrderTraversal();
    }
}
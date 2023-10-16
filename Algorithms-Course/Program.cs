﻿using Algorithms_DataStruct_Lib;
using System.Diagnostics;

namespace Algorithms_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            NodeExamples();

            Console.ReadKey();
        }

        private static void NodeExamples()
        {
            Node first = new Node() { Value = 5 };
            Node second = new Node() { Value = 1 };
            Node third = new Node() { Value = 3 };

            first.Next = second;
            second.Next = third;

            PrintOutLinkedList(first);
        }

        private static void PrintOutLinkedList(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

        }

        private static int RecursiveFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * RecursiveFactorial(n - 1);
        }

        private static int IterativeFactorial(int number) 
        {
            if (number == 0)
                return 1;

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static void TestThreeSum()
        {
            //0:00:00,0036967 second for 16k QuickSort
            var ints = In.ReadInts("Data\\16kints.txt").ToArray();

            var watch = new Stopwatch();
            watch.Start();

            Sorting.QuickSort(ints);

            //var triplets = ThreeSum.Count(ints);

            watch.Stop();

            //Console.WriteLine($"The number of \"zero-sum\" triplets:{triplets}");
            Console.WriteLine($"Time taken:{watch.Elapsed:g}");
        }
    }
}
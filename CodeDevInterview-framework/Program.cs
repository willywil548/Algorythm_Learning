using CodeDevInterview_framework.CodeQuestions;
using System;

namespace CodeDevInterview_framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            UniqueBinarySearchTrees.PrintNodes(3);

            Console.WriteLine($"Maxium Sum:{MaximumPathForABinaryTree.FindMaxSum()}");

            Console.WriteLine($"Finished in:{DateTime.Now - dateTime}");
            Console.ReadKey();
        }
    }
}

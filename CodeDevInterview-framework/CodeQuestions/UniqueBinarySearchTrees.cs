using System;
using System.Collections.Generic;

namespace CodeDevInterview_framework.CodeQuestions
{
    public static class UniqueBinarySearchTrees
    {
        public static int LowConstraint { get; set; } = 1;
        public static int HighConstraint { get; set;} = 15;

        public static List<TreeNode> GenerateTrees(int a)
        {
            // Constraint
            if (a < LowConstraint || a > 30)
            {
                return new List<TreeNode>();
            }

            return GenerateTreeNodes(LowConstraint, a);
        }

        private static List<TreeNode> GenerateTreeNodes(int low, int high)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            if (low > high)
            {
                treeNodes.Add(null);
                return treeNodes;
            }

            for(int i = low; i <= high; i++)
            {
                List<TreeNode> leftTreeNode = GenerateTreeNodes(low, i - 1);
                List<TreeNode> rightTreeNode = GenerateTreeNodes(i + 1, high);

                int current = i;

                for(int j = 0; j < leftTreeNode.Count; j++)
                {
                    for(int k = 0; k < rightTreeNode.Count; k++)
                    {
                        TreeNode node = new TreeNode(current);
                        node.LeftTreeNode = leftTreeNode[j];
                        node.RightTreeNode = rightTreeNode[k];
                        treeNodes.Add(node);
                    }
                }
            }

            return treeNodes;
        }

        public static void PrintNodes(int a)
        {
            foreach(var node in GenerateTrees(a))
            {
                Console.WriteLine(node);
            }
        }
    }
}

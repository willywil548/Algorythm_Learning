using System;

namespace CodeDevInterview_framework.CodeQuestions
{
    public class MaximumPathForABinaryTree
    {
        public class Res
        {
            public int Value { get; set; } = int.MinValue;
        }

        public TreeNode RootNode { get; set; }

        public MaximumPathForABinaryTree()
        {
            RootNode = CreateChild(10,
                                CreateChild(2,
                                    CreateChild(20, null, null),
                                    CreateChild(1, null, null)),
                                CreateChild(10,
                                    null,
                                    CreateChild(-25,
                                        CreateChild(3, null, null),
                                        CreateChild(4, null, null))
                                    )
                                );

        }

        public static int FindMaxSum(TreeNode node = null)
        {
            if (node == null)
            {
                node = new MaximumPathForABinaryTree().RootNode;
            }
            
            Res res = new Res();

            Console.WriteLine($"Using node tree:{node}");
            
            _ = FindMaxUtil(node, res);

            return res.Value;
        }

        private static int FindMaxUtil(TreeNode node, Res res)
        {
            if (node == null)
            {
                return 0;
            }

            int l = FindMaxUtil(node.LeftTreeNode, res);
            int r = FindMaxUtil(node.RightTreeNode, res);

            // Compare the top value from the left and side plus the node value
            // to the node value.
            // This is done as the because the children may be reducing the total value
            // and the goal here is to find the max value.
            int max_single = Math.Max(Math.Max(l, r) + node.Data, node.Data);

            // The top max allows us to add the combination of node paths.
            int max_top = Math.Max(max_single, l + r + node.Data);

            res.Value = Math.Max(res.Value, max_top);

            return max_single;
        }


        private TreeNode CreateChild(int data, TreeNode left, TreeNode right)
        {
            TreeNode child = new TreeNode(data);
            child.LeftTreeNode = left;
            child.RightTreeNode = right;

            return child;
        }
    }
}

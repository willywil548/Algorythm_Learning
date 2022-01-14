namespace CodeDevInterview_framework.CodeQuestions
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode LeftTreeNode { get; set; }
        public TreeNode RightTreeNode { get; set; }

        public TreeNode(int input)
        {
            Data = input;
        }

        public override string ToString()
        {
            return $"[{Data},l-{LeftTreeNode},r-{RightTreeNode}]";
        }
    }
}

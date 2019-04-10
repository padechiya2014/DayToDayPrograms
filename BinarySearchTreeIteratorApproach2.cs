using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    
    public class BSTIterator
    {

        TreeNode _root;
        //Queue<TreeNode> queue = new Queue<TreeNode>();
        Queue<int> queue = new Queue<int>();

        public void InOrder(TreeNode root)
        {
            if (root != null)

            {
                InOrder(root.left);
                queue.Enqueue(root.val);
                Console.Write(root.val + " ");
                InOrder(root.right);
            }
        }
        public BSTIterator(TreeNode rootIn)
        {
            _root = rootIn;
        }

        /** @return the next smallest number */
        public int Next()
        {
            if (HasNext())
            {
                return queue.Dequeue();
            }
            return 0;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            if (queue.Count > 0)
            {
                return true;
            }

            return false;
        }


        public static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(8);

            tree.left = new TreeNode(3);
            tree.right = new TreeNode(9);

            tree.left.left = new TreeNode(1);

            tree.left.right = new TreeNode(5);

            tree.left.right.left = new TreeNode(4);
            tree.left.right.right = new TreeNode(7);

           
            tree.right.right = new TreeNode(12);
            tree.right.right.left = new TreeNode(11);

            BSTIterator obj = new BSTIterator(tree);
            obj.InOrder(tree);
            bool param_2 = true;
            while (param_2 == true)
            {
                int param_1 = obj.Next();
                //Console.Write(param_1);
                param_2 = obj.HasNext();
            }

        }
    }



    /**
     * Your BSTIterator object will be instantiated and called as such:
     * BSTIterator obj = new BSTIterator(root);
     * int param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}

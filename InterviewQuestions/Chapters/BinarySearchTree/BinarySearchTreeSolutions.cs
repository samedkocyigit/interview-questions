using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Chapters.BinarySearchTree
{
    public class BinarySearchTreeSolutions
    {
        public class Node
        {
            public int data;
            public Node? LeftNode;
            public Node? RightNode;
            public Node(int d)
            {
                data = d;
                LeftNode = RightNode = null;
            }
        }

        public Node? root;

        public virtual Node? sortedArrayToBST(int[] arr,
                                      int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            Node node = new Node(arr[mid]);

            node.LeftNode = sortedArrayToBST(arr, start, mid - 1);

            node.RightNode = sortedArrayToBST(arr, mid + 1, end);

            return node;
        }
        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.root);
        }
        public int GetTreeDepth(Node node)
        {
            return node == null ? 0 : Math.Max(GetTreeDepth(node.LeftNode), GetTreeDepth(node.RightNode)) + 1;
        }
    }
}

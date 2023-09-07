using InterviewQuestions.Chapters.BinarySearchTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionsTests.Chapters.BinarySearchTrees
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        private static int findMinDepth(int length)
        {
            int depth = 0;
            for (int i = 0; i < length; i++)
            {
                if (Math.Pow(2, i) - 1 >= length)
                {
                    depth = i - 1;
                    break;
                };
            }
            return depth;
        }
        [TestMethod]
        public void BinarySearchTreeTest()
        {
            BinarySearchTree bts = new BinarySearchTree();
            int[] arr1 = new int[] { 14, 17, 20, 28, 32, 42, 52, };
            int n = arr1.Length;
            int depth = findMinDepth(n);
            BinarySearchTree.Node root = bts.sortedArrayToBST(arr1, 0, n - 1);
            int depthTest = bts.GetTreeDepth(root);

            Assert.AreEqual(depthTest,3 );
        }
        [TestMethod]
        public void BinarySearchTreeTest2()
        {
            BinarySearchTree bts = new BinarySearchTree();
            int[] arr1 = new int[] { 1, 3, 5, 7, 10, 16, 19, 25 };
            int n = arr1.Length;
            int depth =findMinDepth(n);
            BinarySearchTree.Node root = bts.sortedArrayToBST(arr1, 0, n - 1);
            int depthTest= bts.GetTreeDepth(root);

            Assert.AreEqual(depthTest,4 );
        }
    }
}

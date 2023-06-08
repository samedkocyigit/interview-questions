using InterviewQuestions.Chapters.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionsTests.Chapters.BinarySearchTree
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void BinarySearchTreeTest()
        {

            BinarySearchTreeSolutions bts = new BinarySearchTreeSolutions();
            int[] arr1 = new int[] { 14, 17, 20, 28, 32, 42, 52, };
            int n = arr1.Length;
            BinarySearchTreeSolutions.Node root = bts.sortedArrayToBST(arr1, 0, n - 1);
            int depth = bts.GetTreeDepth(root);

            Assert.AreEqual(depth, 3);
        }
        [TestMethod]
        public void BinarySearchTreeTest2()
        {

            BinarySearchTreeSolutions bts = new BinarySearchTreeSolutions();
            int[] arr1 = new int[] { 1, 3, 5, 7, 10, 16, 19, 25 };
            int n = arr1.Length;
            BinarySearchTreeSolutions.Node root = bts.sortedArrayToBST(arr1, 0, n - 1);
            int depth = bts.GetTreeDepth(root);

            Assert.AreEqual(depth, 4);
        }
    }
}

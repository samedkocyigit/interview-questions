using InterviewQuestions.Chapters.BinarySearchTree;

namespace InterviewQuestionsTests.Chapters.BinarySearchTree
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

            BinarySearchTreeSolutions bts = new BinarySearchTreeSolutions();
            int[] arr1 = new int[] { 14, 17, 20, 28, 32, 42, 52, };
            int n = arr1.Length;
            BinarySearchTreeSolutions.Node root = bts.sortedArrayToBST(arr1, 0, n - 1);
            int depth = bts.GetTreeDepth(root);
            int minDepth = findMinDepth(n);

            Assert.AreEqual(depth, minDepth);
        }
        [TestMethod]
        public void BinarySearchTreeTest2()
        {

            BinarySearchTreeSolutions bts = new BinarySearchTreeSolutions();
            int[] arr1 = new int[] { 1, 3, 5, 7, 10, 16, 19, 25 };
            int n = arr1.Length;
            BinarySearchTreeSolutions.Node root = bts.sortedArrayToBST(arr1, 0, n - 1);
            int depth = bts.GetTreeDepth(root);
            int minDepth = findMinDepth(n);

            Assert.AreEqual(depth, minDepth);
        }
    }
}

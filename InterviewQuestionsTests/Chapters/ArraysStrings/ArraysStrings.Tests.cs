using InterviewQuestions.Chapters.ArraysStrings;

namespace InterviewQuestionsTests.Chapters.ArraysStrings
{
    [TestClass]
    public class ArraysStringsTests
    {
        [DataTestMethod]
        [DataRow("abcdef", true)]
        [DataRow("abcdea", false)]
        [DataRow("abcdeA", true)]
        [DataRow("abcdef g", true)]
        [DataRow("abcdef b", false)]
        public void isStringUniqTest(string input, bool expectedResult)

        {
            ArraysAndStringSolutions testObject = new ArraysAndStringSolutions();

            bool output = testObject.isStringUniq(input);
            bool outputSecond = testObject.isStringUniqSecondSolution(input);


            Assert.AreEqual(expectedResult, output);
            Assert.AreEqual(expectedResult, outputSecond);
        }

        [DataTestMethod]
        [DataRow("aaabbcccccdd", "a3b2c5d2")]
        [DataRow("aabcde", "aabcde")]
        [DataRow("aaaaabccdeee", "a5b1c2d1e3")]
        [DataRow("abcdef", "abcdef")]
        public void stringCompression(string input, string expectedResult)
        {
            ArraysAndStringSolutions testObject1 = new ArraysAndStringSolutions();

            string solution = testObject1.stringCompression(input);
            string alternateSolution = testObject1.stringCompressionAlternate(input);

            Assert.AreEqual(expectedResult, solution);
            Assert.AreEqual(expectedResult, alternateSolution);
        }
        [DataTestMethod]
        [DataRow("abdulsamed", "demasludba", true)]
        [DataRow("furkan", "furcan", false)]
        [DataRow("ali", "lia", true)]
        public void stringPermutation(string input, string testString, bool expectedResult)
        {
            ArraysAndStringSolutions testObjecet2 = new ArraysAndStringSolutions();

            bool solution = testObjecet2.isStringPermutation(input, testString);

            Assert.AreEqual(expectedResult, solution);
        }
        [TestMethod]
        public void zeroMatrix()
        {
            ArraysAndStringSolutions testObject = new ArraysAndStringSolutions();

            int[,] inputArray = new int[3, 4] { { 1, 1, 1, 1 },
                                                { 2, 2, 2, 2 },
                                                { 3, 3, 0, 3 }, };

            int[,] secArray = new int[3, 3] { {1,2,3 },
                                              {1,0,1 },
                                              {1,1,1} };

            int[,] solution = testObject.zeroesMatrix(inputArray);
            int[,] solution2 = testObject.zeroesMatrix(secArray);

            Assert.AreEqual(1, solution2[0, 0]);
            Assert.AreEqual(0, solution2[0, 1]);
            Assert.AreEqual(3, solution2[0, 2]);
            Assert.AreEqual(0, solution2[1, 0]);
            Assert.AreEqual(0, solution2[1, 1]);
            Assert.AreEqual(0, solution2[1, 2]);
            Assert.AreEqual(1, solution2[2, 0]);
            Assert.AreEqual(0, solution2[2, 1]);
            Assert.AreEqual(1, solution2[2, 2]);

            Assert.AreEqual(1, solution[0, 0]);
            Assert.AreEqual(1, solution[0, 1]);
            Assert.AreEqual(0, solution[0, 2]);
            Assert.AreEqual(1, solution[0, 3]);
            Assert.AreEqual(2, solution[1, 0]);
            Assert.AreEqual(2, solution[1, 1]);
            Assert.AreEqual(0, solution[1, 2]);
            Assert.AreEqual(2, solution[1, 3]);
            Assert.AreEqual(0, solution[2, 0]);
            Assert.AreEqual(0, solution[2, 1]);
            Assert.AreEqual(0, solution[2, 2]);
            Assert.AreEqual(0, solution[2, 3]);

        }
    }
}

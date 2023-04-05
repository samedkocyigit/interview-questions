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
        public void zeroMatrix(int[,] input, int[,] expectedResult)
        {
            ArraysAndStringSolutions testObject = new ArraysAndStringSolutions();

            int[,] solution = testObject.zeroesMatrix(input);

            //Assert.AreEqual(expectedResult,solution);
        }
    }
}

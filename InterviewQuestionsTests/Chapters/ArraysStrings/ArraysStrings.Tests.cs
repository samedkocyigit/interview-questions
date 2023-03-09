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
    }
}

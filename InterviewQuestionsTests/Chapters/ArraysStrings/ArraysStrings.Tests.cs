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
        [DataRow("aaabbcccccdd","a3b2c5d2")]
        [DataRow("aabcde", "aabcde")]
        [DataRow("aaaaabccdeee", "a5b1c2d1e3")]
        [DataRow("abcdef","abcdef" )]
        public void stringCompression(string input, string expectedResult)
        {
            ArraysAndStringSolutions testObject1 = new ArraysAndStringSolutions();

            string solution = testObject1.stringCompression(input);
            
            Assert.AreEqual(expectedResult, solution);
        }
    }
}

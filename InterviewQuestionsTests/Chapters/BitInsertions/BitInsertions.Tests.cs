using InterviewQuestions.Chapters.BitInsertion;

namespace InterviewQuestionsTests.Chapters.BitInsertion
{
    [TestClass] 
    public class BitInsertionTest
    {
        [DataTestMethod]
        [DataRow(128,19,2,6,204)]
        [DataRow(65, 12, 1, 4, 89)]
        [DataRow(2560, 7, 3, 5, 2616)]
        [DataRow(145, 10, 2, 5, 184)]
        public void bitInsertionTest(int firstNum, int secNum, int startBit, int endBit, int expectedResult)
        {
            BitInsertions test1 = new BitInsertions();
            int temp =test1.BitInsertionSolution(firstNum,secNum,startBit,endBit);

            Assert.AreEqual(temp, expectedResult);
        }
    }

}

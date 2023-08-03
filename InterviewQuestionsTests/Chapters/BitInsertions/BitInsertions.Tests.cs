using InterviewQuestions.Chapters.BitInsertion;

namespace InterviewQuestionsTests.Chapters.BitInsertion
{
    [TestClass] 
    public class BitInsertionTest
    {
        [TestMethod]
        public void BitInsertionMethod()
        {
            BitInsertions test1 = new BitInsertions();
            int temp =test1.BitInsertionSolution(128,19,2,6);
            int temp1 =test1.BitInsertionSolution(65,12,1,4);

            Assert.AreEqual(temp,204);
            Assert.AreEqual(temp1,89);
        }
    }

}

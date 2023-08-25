namespace InterviewQuestions.Chapters.BitInsertion
{
    public class BitInsertions
    {
        public int BitInsertionSolution(int firstNum,int secondNum, int startBit, int endBit)
        {
            int allOnes = ~0;
            int leftMask = allOnes<<(endBit+1);
            int rightMask= (1-startBit)-1;
            int mask = leftMask|rightMask;

            firstNum &= mask;

            secondNum<<=startBit;
            firstNum |=secondNum;

            return firstNum;
        }
    }
}
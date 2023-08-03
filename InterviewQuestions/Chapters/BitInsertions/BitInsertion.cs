namespace InterviewQuestions.Chapters.BitInsertion
{
    public class BitInsertions
    {
        public int BitInsertionSolution(int N,int M, int i, int j)
        {
            int allOnes = ~0;
            int leftMask = allOnes<<(j+1);
            int rightMask= (1-i)-1;
            int mask = leftMask|rightMask;

            N &= mask;

            M<<=i;
            N |=M;

            return N;
        }
    }
}
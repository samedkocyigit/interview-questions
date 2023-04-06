using System.Security.Cryptography.X509Certificates;

namespace InterviewQuestions.Chapters.ArraysStrings
{
    public class ArraysAndStringSolutions
    {
        public bool isStringUniq(string input)
        {
            bool isUniq = true;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        isUniq = false;
                    }
                }
            }
            return isUniq;
        }

        public bool isStringUniqSecondSolution(string input)
        {
            bool isUniq = true;
            bool[] chars = new bool[128];
            for (int i = 0; i < input.Length; i++)
            {
                var val = input.ElementAt(i);
                if (chars[val])
                {
                    isUniq = false;
                }
                chars[val] = true;
            }
            return isUniq;
        }
        public string stringCompression(string input)
        {
            string newString = "";
            int counter = 1;
            for(int i = 0; i < input.Length;)
            {
                while ((i+counter) < input.Length && input[i] == input[i+counter])
                {
                    counter++;
                }    
                newString += input[i]+counter.ToString();
                i += counter;
                counter = 1;
            }
            return (newString.Length < input.Length) ? newString : input;
        }
        public string stringCompressionAlternate(string input) 
        {
            string compressedString = "";
            int count = 0;
            for(int i = 0; i < input.Length; i++)
            {
                count++;
                if(i+1>=input.Length || input[i]!= input[i + 1])
                {   
                    compressedString += input[i]+count.ToString();
                    count = 0;
                }
            }
            return (input.Length<compressedString.Length) ? input : compressedString; 
        }
        public bool isStringPermutation(string firstString,string secondString)
        {
            bool flag = false;
            char []ch1 = firstString.ToCharArray();
            char []ch2= secondString.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            if (firstString.Length != secondString.Length) 
                return flag;
            
            for(int i=0;i<firstString.Length;i++)
            {
                if (ch1[i]!= ch2[i]) 
                    return flag;
            }
            flag = true;
            return flag;    

        }
        public int[,] zeroesMatrix(int[,] matrix)
        {
            int row=matrix.GetLength(0);
            int col=matrix.GetLength(1);
            int[,] testMatrix= new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    testMatrix[i, j] = matrix[i, j];
                }
            }
            for (int i=0; i < row; i++)
            {
                for(int j=0; j < col; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        for(int k=0; k < row; k++)
                        {
                            testMatrix[i, k] = 0;
                            testMatrix[k, j] = 0;
                        }
                    }
                }
            }
            return testMatrix;
        }
    }
}

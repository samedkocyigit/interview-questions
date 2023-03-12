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
            int i = 0;
            while(i< input.Length)
            {
                int counter = 1;
                while (input[i] == input[i+1] && i<input.Length-1)
                {
                    counter++;
                    i++;
                    if (i == input.Length - 1) {break;} //a limiter for that the index does not exceed the limits of the array
                }
                newString += input[i];
                newString += counter;
                i++;
                if (i == input.Length - 1)
                {
                    newString += input[i - 1];
                    newString += counter;
                    break;
                }
            }
            if (newString.Length < input.Lengt)
                return newString;
            else
                return input;
        }
    }
}

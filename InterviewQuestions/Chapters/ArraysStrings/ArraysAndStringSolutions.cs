namespace InterviewQuestions.Chapters.ArraysStrings
{
    public class ArraysAndStringSolutions
    {
        public bool isStringUniq(string input)
        {
            bool isUniq;
            string first ="";
            string sec ="";
            for(int i=0;i<input.Length;i++){
                first=input.Substring(i,1);
                for(int j=0; j<input.Length;j++){
                    sec =input.Substring(j,1);
                    if((first==sec)&&(i!=j)){
                        isUniq=false;
                        return isUniq;
                    }
                        
                }
            }
            isUniq=true;
            
            //TODO: Implement a method thet returns true if the string has all unique characters

            return isUniq;
        }
    }
}

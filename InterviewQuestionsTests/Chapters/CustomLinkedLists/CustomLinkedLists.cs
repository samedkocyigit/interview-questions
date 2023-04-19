
using InterviewQuestions.Chapters.CustomLinkedLists;

namespace InterviewQuestionsTests.Chapters.CustomLinkedLists
{
    [TestClass]
    
    public class CustomLinkedLists
    {
        [TestMethod]
        public void method()
        {
            CustomLinkedListsMethods list=new CustomLinkedListsMethods();
            list.add(15);
            list.add(11);
            list.add(12);   
            list.add(13);

            Assert.AreEqual(list.head.data, 15);
            Assert.AreEqual(list.head.next.data, 11);
        }
        
           
    }
}

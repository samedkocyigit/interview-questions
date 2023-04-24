using InterviewQuestions.Chapters.CustomLinkedLists;

namespace InterviewQuestionsTests.Chapters.CustomLinkedLists
{
    [TestClass]

    public class CustomLinkedListTests
    {
        [TestMethod]
        public void CustomLinkedListAddTest()
        {
            CustomLinkedList list = new CustomLinkedList();

            list.add(10);
            list.add(11);
            list.add(12);
            list.add(13);

            Assert.AreEqual(list?.head?.data, 10);
            Assert.AreEqual(list?.head?.next?.data, 11);
            Assert.AreEqual(list?.head?.next?.next?.data, 12);
            Assert.AreEqual(list?.head?.next?.next?.next?.data, 13);
            Assert.AreEqual(list?.head?.next?.next?.next?.next, null);
        }


    }
}

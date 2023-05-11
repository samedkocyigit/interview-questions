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
        [TestMethod]
        public void getKthLastElementTest()
        {
            CustomLinkedList list = new CustomLinkedList();
            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);
            list.add(5);

            Assert.AreEqual(list.getKhtLastElement(1), 5);
            Assert.AreEqual(list.getKhtLastElement(3), 3);
            Assert.AreEqual(list.getKhtLastElement(5), 1);
            Assert.ThrowsException<IndexOutOfRangeException>(() => list.getKhtLastElement(7));
        }

        [TestMethod]
        public void getLastKthLastElementAlternativeTest()
        {
            CustomLinkedList list = new CustomLinkedList();
            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);
            list.add(5);

            Assert.AreEqual(list.getLastKthElementAlternative(1), 5);
            Assert.AreEqual(list.getLastKthElementAlternative(3), 3);
            Assert.AreEqual(list.getLastKthElementAlternative(5), 1);
            Assert.ThrowsException<IndexOutOfRangeException>(() => list.getLastKthElementAlternative(7));
        }
        [TestMethod]
        public void isListPolindromeTest() 
        {
            CustomLinkedList list = new CustomLinkedList();
            list.add(1); 
            list.add(2);
            list.add(3);
            list.add(2);
            list.add(1);

            bool flag = list.isListPolindrome();

            Assert.AreEqual(flag, true);
        }
        [TestMethod]
        public void isListPolindromeTest2()
        {
            CustomLinkedList list = new CustomLinkedList();
            list.add(1);
            list.add(2);
            list.add(3);
            list.add(3);
            list.add(4);
            list.add(2);
            list.add(1);

            bool flag = list.isListPolindrome();

            Assert.AreEqual(flag, false);
        }
    }
}


namespace InterviewQuestionsTests.Chapters.CustomLinkedLists
{
    [TestClass]
    
    public class CustomLinkedLists
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data) 
            {
                this.data = data;
                this.next = null;
            }
        }
        public Node head;

        public CustomLinkedLists() 
        {
            head = null;
        }
        public void add(int newElement)
        {
            Node newNode = new Node(newElement);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
        }
        [TestMethod]
        public void method()
        {
            CustomLinkedLists list = new CustomLinkedLists();
            list.add(10);
            list.add(11);
            list.add(12);   
            list.add(13);

            Assert.AreEqual(list.head.data, 10);
            Assert.AreEqual(list.head.next.data, 11);
        }
        
           
    }
}

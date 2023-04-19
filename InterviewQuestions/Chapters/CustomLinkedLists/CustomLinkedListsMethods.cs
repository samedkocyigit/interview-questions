using System.Security.Cryptography.X509Certificates;

namespace InterviewQuestions.Chapters.CustomLinkedLists
{
    public class CustomLinkedListsMethods
    {
        public class Node
        {
            public int data;
            public Node? next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public Node? head;

        public CustomLinkedListsMethods()
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
    }
}

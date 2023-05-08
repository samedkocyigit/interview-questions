using System.Diagnostics;
using System.Security;

namespace InterviewQuestions.Chapters.CustomLinkedLists
{
    public class CustomLinkedList
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

        public CustomLinkedList()
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
        public int getLenght()
        {
            Node? currentNode= head;
            int lenght = 0;
            while (currentNode != null)
            {
                currentNode = currentNode.next;
                lenght++;
            }
            return lenght;
        }
        public int getKhtLastElement(int index)
        {
            Node? currentNode = head;
            int lenght = getLenght();

            if (lenght < index)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            for (int i = 1; i < lenght - index + 1; i++)
                currentNode = currentNode?.next;

            if (currentNode != null)
            {
                return currentNode.data;
            }
            else
                throw new Exception("Error: current node is null.");

        }
    }
}

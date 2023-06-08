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
            Node? currentNode = head;
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

        public int getLastKthElementAlternative(int index)
        {
            Node? iteratorFast = head;
            Node? iteratorSlow = head;

            if (index > this.getLenght())
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }

            for (int i = 0; i < index; i++)
            {
                if (iteratorFast == null) return -999999;
                iteratorFast = iteratorFast.next;

            }

            while (iteratorFast != null)
            {
                iteratorFast = iteratorFast.next;
                iteratorSlow = iteratorSlow?.next;
            }
            if (iteratorSlow != null)
            {
                return iteratorSlow.data;
            }
            else
                throw new Exception("Error: current node is null.");
        }
        public bool isListPolindrome()
        {   
            Node? currentNode=head;
            bool flag = true;
            int index = this.getLenght()/2;
            
            for(int i = 1; i <= index; i++)
            {
                if(currentNode?.data != this.getKhtLastElement(i))
                    flag=false;
                currentNode= currentNode?.next;
            }
            return flag;
        }
    }
    //public class BinarySearchTree
    //{
    //    public class Node
    //    {
    //        public int data;
    //        public Node? LeftNode;
    //        public Node? RightNode;
    //        public Node(int d)
    //        {
    //            data = d;
    //            LeftNode = RightNode = null;
    //        }
    //    }

    //    public  Node? root;

    //    public virtual Node sortedArrayToBST(int[] arr,
    //                                 int start, int end)
    //    {
    //        if (start > end)
    //        {
    //            return null;
    //        }

    //        int mid = (start + end) / 2;
    //        Node node = new Node(arr[mid]);

    //        node.LeftNode = sortedArrayToBST(arr, start, mid - 1);

    //        node.RightNode = sortedArrayToBST(arr, mid + 1, end);

    //        return node;
    //    }
    //    public int GetTreeDepth()
    //    {
    //       return this.GetTreeDepth(this.root);
    //    }
    //    public int GetTreeDepth(Node node)
    //    {
    //        return node == null ? 0 : Math.Max(GetTreeDepth(node.LeftNode), GetTreeDepth(node.RightNode)) + 1;
    //    }
    //}
}

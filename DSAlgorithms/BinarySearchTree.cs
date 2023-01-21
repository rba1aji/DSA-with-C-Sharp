namespace DSAlgorithms
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public class Node
        {
            public Node left;
            public Node right;
            public int data;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public void Insert(int data)
        {
            if (root == null)
                root = new Node(data);
            else if (data > root.data)
                root.right = Insert(data, root.right);
            else
                root.left = Insert(data, root.left);
            Console.WriteLine("inserted " + data);
        }

        private Node Insert(int data, Node r)
        {
            if (r == null) return new Node(data);
            else if (data > root.data) return Insert(data, r.right);
            return Insert(data, r.left);
        }

    }

}
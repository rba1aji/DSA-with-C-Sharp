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
            Insert(ref root, data);

            //if (root == null)
            //    root = new Node(data);
            //else if (data > root.data)
            //    root.right = Insert(data, root.right);
            //else
            //    root.left = Insert(data, root.left);
            //Console.WriteLine("inserted " + data);
        }

        private void Insert(ref Node root, int data)
        {
            if (root == null) root = new Node(data);
            else if (root.data < data) Insert(ref root.right, data);
            else Insert(ref root.left, data);
            Console.WriteLine("inserted" + data);
        }

        //private Node Insert(int data, Node r)
        //{
        //    if (r == null) return new Node(data);
        //    else if (data > root.data) return Insert(data, r.right);
        //    return Insert(data, r.left);
        //}

        public void InOrderTraversal()
        {
            Console.WriteLine("Inorder traversal");
            InOrderTraversal(root);
        }

        private void InOrderTraversal(Node root)
        {
            if (root == null)
            {
                //Console.WriteLine("root null");
                return;
            }
            Console.Write(root.data + " ");
            InOrderTraversal(root.left);
            InOrderTraversal(root.right);
        }
    }

}
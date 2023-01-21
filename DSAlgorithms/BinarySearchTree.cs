namespace DSAlgorithms
{
    public class BinarySearchTree
    {
        private Node root;
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
                this.left = null;
                this.right = null;  
            }
        }

        public void Insert(int data)
        {
            root = Insert(root, data);

            //if (root == null)
            //    root = new Node(data);
            //else if (data > root.data)
            //    root.right = Insert(data, root.right);
            //else
            //    root.left = Insert(data, root.left);
            //Console.WriteLine("inserted " + data);
        }

        private Node Insert(Node root, int data)
        {
            if (root == null) root = new Node(data);
            else if (root.data < data) root.right = Insert(root.right, data);
            else root.left = Insert(root.left, data);
            Console.WriteLine("inserted" + data);
            return root;
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
            InOrderTraversal(root.left);
            Console.Write(root.data + " ");
            InOrderTraversal(root.right);
        }

        public void PreOrderTraversal()
        {
            Console.WriteLine("\nPreorder");
            PreOrderTraversal(root);
        }

        private void PreOrderTraversal(Node root)
        {
            if (root == null) return;
            Console.Write(root.data + " ");
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
        }

        public void PostOrderTraversal()
        {
            Console.WriteLine("\nPostorder");
            PostOrderTraversal(root);
        }

        private void PostOrderTraversal(Node root)
        {
            if (root == null) return;
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
            Console.Write(root.data + " ");
        }
    }

}
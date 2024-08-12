using System.Collections;

namespace Binary_Search_Tree
{
    // prefix r before each function is stand for recursion
    internal class BST
    {

        public static Node RInsert(Node node, int value)
        {
            Node inserted = new(value);
            if (node == null)
            {
                return inserted;
            }
            else
            {
                if (inserted.value < node.value)
                {
                    node.left = RInsert(node.left, value);
                }
                else if (inserted.value > node.value)
                {
                    node.right = RInsert(node.right, value);
                }
            }
            return node;
        }

        public static void RInorderTraverse(Node node)
        {
            if (node == null) return;
            RInorderTraverse(node.left);
            // Add action with current node here
            RInorderTraverse(node.right);
        }

        public static void RPreOrderTraverse(Node node)
        {
            if (node == null) return;
            // add action with current node here
            RPreOrderTraverse(node.left);
            RPreOrderTraverse(node.right);
        }

        public static void RPostOrderTraverse(Node node)
        {
            RPostOrderTraverse(node.left);
            RPostOrderTraverse(node.right);
            // add action with current node here
        }

        /**pseudo code for inorder traverse iterative 
         * while node not null or stack not empty
         *      while node not null
         *          stack push node
         *          node <- node.next
         *      node = stack.pop
         *      // action with node here
         *      node = node.right
        */
        public static void InorderTraverse(Node node)
        {
            Node current = node;
            Stack<Node> stack = new();
            while (current != null || stack.Count != 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                current = stack.Pop();
                // action with current node here
                Console.WriteLine(current.value);
                current = current.right;
            }
        }

        /** pseudo code for preorder traverse iterative
         * while node not null or stack not empty
         *      if node not null
         *          //add action with node 
         *          if node.right not null
         *              stack.push(node.right)
         *          node = node.left
         *      else 
         *          node = stack.pop()
         */
        public static void PreorderTraverse(Node node)
        {

            Stack<Node> stack = new();
            Node current = node;
            while (current != null || stack.Count != 0)
            {
                if (current != null)
                {
                    // add action with current node
                    Console.WriteLine(current.value);
                    if (current.right != null)
                    {
                        stack.Push(current.right);
                    }
                    current = current.left;
                }
                else
                {
                    current = stack.Pop();
                }
            }
        }

        /**pseudo code for postorder traverse iterative
         * while stack is not empty and node is not null
         *      while node not null
         *          if node.right not null
         *              stack push node.right
         *          stack push node
         *          node = node.left
         *      
         *      node = stack.pop
         *      if node.right not null and node.right = stack.top ( check empty stack to avoid null point exception ) 
         *          stack.pop
         *          stack.push(node)
         *          node = node.right   
         *      else 
         *          // add action with node here
         *          node = null
         */

        public static void PostOrderTraverse(Node node) {
            Stack<Node> stack = new();
            Node current = node;
            while(current != null || stack.Count != 0)
            {
                while(current != null)
                {
                    if(current.right != null) stack.Push(current.right);
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                if (current.right != null && stack.Count > 0 && current.right == stack.Peek()) 
                {
                    stack.Pop();    
                    stack.Push(current);
                    current = current.right;
                }
                else
                {
                    // add action with current node here
                    Console.WriteLine(current.value);
                    current = null;
                }
            }
        }
    }
}

package struct;

import java.util.Stack;

class Node {

    int val;
    Node left;
    Node right;

    Node(int val) {
        this.val = val;
        this.left = null;
        this.right = null;
    }

    Node(int val, Node left, Node right) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BST {

    private Node root;

    public BST() {
        this.root = null;
    }

    public void insert(int val) {
        Node parrent = null;
        Node current = root;
        while (current != null) {
            parrent = current;
            if (val == current.val) {
                return;
            } else if (val < current.val) {
                current = current.left;
            } else {
                current = current.right;
            }
        }
        if (parrent == null) {
            this.root = new Node(val);
        } else if (val < parrent.val) {
            parrent.left = new Node(val);
        } else {
            parrent.right = new Node(val);
        }
    }

    public void inOrderTraverse() {
        Stack<Node> st = new Stack<>();
        Node current = this.root;
        while (current != null || !st.isEmpty()) {
            while (current != null) {
                st.push(current);
                current = current.left;
            }
            current = st.pop();
            System.out.print(current.val + " ");
            current = current.right;
        }
        System.out.println("");
    }

    public void deleteByCopyLeft(int val) {
        Node parrent = null;
        Node current = root;
        while (current != null) {
            if (val == current.val) {
                break;
            }
            parrent = current;
            if (val < current.val) {
                current = current.left;
            } else {
                current = current.right;
            }

        }
        if (current == null) {
            System.out.println("Not Found");
            return;
        }
        if (current.left != null && current.right != null) {
            Node tmp = current;
            parrent = current;
            current = current.left;
            while (current.right != null) {
                parrent = current;
                current = current.right;
            }
            tmp.val = current.val;
        }
        
        Node child = null;
        if (current.left != null) {
            child = current.left;
        } else {
            child = current.right;
        }

        if (current == root) {
            this.root = child;
        } else if (parrent.left == current) {
            parrent.left = child;
        } else {
            parrent.right = child;
        }
    }
}

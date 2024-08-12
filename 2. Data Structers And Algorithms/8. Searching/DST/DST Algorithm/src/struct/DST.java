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

public class DST {

    private Node root;

    public DST() {
        this.root = null;
    }

    private int getBit(int val, int bit) {
        return (val / (int) Math.pow(2, bit)) % 2;
    }

    private Node iInsert(Node node, int val, int bit) {
        if (node == null) {
            return new Node(val);
        } else if (getBit(val, bit) == 0) {
            node.left = iInsert(node.left, val, bit - 1);
        } else {
            node.right = iInsert(node.right, val, bit - 1);
        }
        return node;
    }

    public void insert(int val) {
        if (this.root == null) {
            this.root = new Node(val);
            return ;
        }
        int b = 4; // adjust
        Node current = this.root;
        Node parrent = null;
        while(current != null){
            if(current.val == val) return;
            b --;
            parrent = current;
            if(getBit(val,b) == 0) current = current.left;
            else current = current.right;
        }
        
        if(getBit(val,b) == 0) parrent.left = new Node(val);
        else parrent.right= new Node(val);
        
    }
    
    public void delete(int val){
        int b = 4;
        Node parrent = null;
        Node current = this.root;
        while(current != null && current.val != val) {
            b --;
            parrent = current;
            if (getBit(val,b) == 0) current = current.left;
            else current = current.right;
        }
        
        if(current.left != null && current.right != null){
            Node tmp = current;
            parrent = current;
            current= current.left;
            while(current.right != null) {
                parrent = current;
                current = current.right;
            }
            tmp.val = current.val;
        }
        Node child;
        if(current.left != null) child = current.left;
        else child = current.right;
        
        if(current == this.root) this.root = child;
        else if(parrent.left == current) parrent.left = child;
        else parrent.right = child;
        
    }

    public void inOrderTraverse() {
        Stack<Node> st = new Stack<>();
        Node tmp = this.root;
        while (tmp != null || !st.isEmpty()) {
            while (tmp != null) {
                st.add(tmp);
                tmp = tmp.left;
            }
            tmp = st.pop();
            System.out.print(tmp.val + " ");
            tmp = tmp.right;
        }

    }
}

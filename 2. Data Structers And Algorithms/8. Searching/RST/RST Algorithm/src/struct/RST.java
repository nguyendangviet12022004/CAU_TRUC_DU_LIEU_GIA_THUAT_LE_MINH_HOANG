package struct;

import java.util.LinkedList;
import java.util.Queue;

class Node {

    int val;
    Node left;
    Node right;

    Node(){
        this.val = 0;
        this.left = null;
        this.right = null;
    }
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
public class RST {
    private Node root;
    public RST(){
        this.root = new Node();
    }
    private int getBit(int val, int bit) {
        return (val / (int) Math.pow(2, bit)) % 2;
    }
    public void insert(int val){
        int z = 4;
        Node parrent = null;
        Node current = this.root;
        for(int b = z - 1;b >= 0;b --){
            int bit = getBit(val,b);
            parrent = current;
            if(bit == 0) current = current.left;
            else current = current.right;
            
            if(current == null) {
                current = new Node();
                if(bit == 0) parrent.left = current;
                else parrent.right = current;
            }
        }
        current.val = val;
    }
    
    public void delete(int val){
        Node parrent = null;
        Node current = this.root;
        Node turnNode = null;
        Node child = null;
        int z = 4;
        for(int b = z - 1; b >= 0 ; b --){
            if(current == null) return ;
            parrent = current;
            int bit = getBit(val,b);
            if(bit == 0) current = current.left;
            else current = current.right;
            
            if(b == z-1 || (parrent.left != null && parrent.right != null)){
                turnNode = parrent;
                child = current;
            }
        }
        
        if(current == null) return;
        if(turnNode.left == child) turnNode.left = null;
        else turnNode.right = null;
        
        
    }
    public void BFS(){
        Queue<Node> queue = new LinkedList<>();
        queue.add(this.root);
        while(!queue.isEmpty()){
            Node front = queue.poll();
            if(front.val != 0) {
                System.out.print(front.val + " ");
            }
            if(front.left != null) queue.add(front.left);
            if(front.right != null) queue.add(front.right);
        }
    }
}

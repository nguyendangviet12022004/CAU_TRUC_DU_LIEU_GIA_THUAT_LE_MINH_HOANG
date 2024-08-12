package main;

import struct.BST;

public class Main {
    public static void main(String[] args) {
        BST tree = new BST();
        int[] nums = {9,6,8,4,15,32,52,12,25};
        for(int val : nums) tree.insert(val);
        tree.inOrderTraverse();
        tree.deleteByCopyLeft(9);
        tree.inOrderTraverse();
    }
    
}

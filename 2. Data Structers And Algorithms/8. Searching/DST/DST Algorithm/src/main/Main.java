package main;

import struct.DST;

public class Main {

    public static void main(String[] args) {
        int[] a = {6,5,2,7,8,10,12,11,4};
        DST tree = new DST();
        for(int x : a) tree.insert(x);
        tree.inOrderTraverse();
        System.out.println("");
        tree.delete(8);
        tree.inOrderTraverse();
    }
    
}

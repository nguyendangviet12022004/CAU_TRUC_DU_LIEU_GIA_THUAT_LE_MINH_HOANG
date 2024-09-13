/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package main;

import struct.RST;

/**
 *
 * @author ACER
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        RST tree = new RST();
        int[] vals = {4,5,2,11};
        for(int val : vals) tree.insert(val);
        tree.BFS();
        tree.delete(5);
        System.out.println("");
        tree.BFS();
    }
    
}

package logic;

import java.util.Arrays;
import java.util.Stack;
import mock.Data;

public class DFS {
    
    public static void DFS(int[][] graph, int vertices, int start, int end){
        Stack<Integer> stack = new Stack<>();
        int[] pre = new int[vertices + 1];
        Arrays.fill(pre, -1);
        
        stack.push(start);
        pre[start] = Integer.MAX_VALUE;
        while(!stack.isEmpty()){
            int top = stack.pop();
            
            for(int i = vertices ;i >= 1;i --){
                if(pre[i] == -1 && graph[top][i] == 1){
                    stack.push(i);
                    pre[i] = top;
                }
            }
        }
        while(end != start){
            System.out.print(end + " ");
            end = pre[end];
        }
        System.out.println(start);
    }
    public static void main(String[] args) {
        DFS(Data.graph1(), 8, 1, 5);
    }
}

package logic;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.Queue;

import mock.Data;

public class BFS {
    
    public static void bfs(int[][] graph, int vertices, int start, int end){
        Queue<Integer> queue = new LinkedList<>();
        int[] pre = new int[vertices + 1];
        Arrays.fill(pre, -1);
        
        queue.add(start);
        pre[start] = Integer.MAX_VALUE;
        while(!queue.isEmpty()){
            int front = queue.poll();
            for(int i = 1;i <= vertices;i ++){
                if(pre[i] == -1 && graph[front][i] != 0){
                    pre[i] = front;
                    queue.add(i);
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
        bfs(Data.graph1(), 8, 1, 5);
    }
    
}

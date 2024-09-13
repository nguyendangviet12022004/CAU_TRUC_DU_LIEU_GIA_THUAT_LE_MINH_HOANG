package mock;

public class Data {

    public static int[][] graph1() {
        int[][] graph = new int[9][9];
        int[][] edges = {{1, 2}, {1, 3}, {2, 3}, {2, 4}, {3, 5}, {4, 6}, {7, 8}};
        for (int[] edge : edges) {
            graph[edge[0]][edge[1]] = graph[edge[1]][edge[0]] = 1;
        }
        return graph;
    }

}

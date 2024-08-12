
package program;

import struct.Queue;

public class Program {

	public static void main(String[] args) {
		Queue qu = new Queue();
		for(int i = 1;i <= 10;i ++) qu.enqueue(i);
		while(!qu.isEmpty()) System.out.println(qu.dequeue());
	}
	
}

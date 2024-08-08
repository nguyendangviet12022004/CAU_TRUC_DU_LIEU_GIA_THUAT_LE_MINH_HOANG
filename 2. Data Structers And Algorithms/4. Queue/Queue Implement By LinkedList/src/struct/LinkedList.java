package struct;

public class LinkedList {
	private Node head;
	private Node tail;
	
	public LinkedList(){
		this.head = null;
		this.tail = null;
	}
	
	public boolean isEmpty(){
		return this.head == null || this.tail == null;
	}
	
	public int getHead() throws Exception{
		return this.head.data;
	}
	
	public int getTail() throws Exception{
		return this.tail.data;
	}
	
	public void pushHead(int data){
		
	}
}

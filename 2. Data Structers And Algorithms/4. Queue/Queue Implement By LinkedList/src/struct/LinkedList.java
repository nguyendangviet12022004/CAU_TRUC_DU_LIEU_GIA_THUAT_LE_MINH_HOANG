package struct;

public class LinkedList {
	private Node head;
	private Node tail;
	
	public LinkedList(){
		head = null;
		tail = null;
	}
	
	public boolean isEmpty(){
		return head == null || tail == null;
	}
	
	public Node getHead(){
		return head;
	}
	
	public Node getTail(){
		return tail;
	}
	
	public void pushTail(int _data){
		Node node = new Node(_data);
		if(isEmpty()){
			head = tail = node;
		} else {
			tail.next = node;
			tail = node;
		}
	}
	
	public Node popHead(){
		if(isEmpty()) return null;
		Node node = this.head;
		this.head = this.head.next;
		return node;
	}
	
	
}

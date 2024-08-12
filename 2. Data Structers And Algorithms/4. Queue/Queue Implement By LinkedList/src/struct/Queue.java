package struct;

public class Queue {
	private LinkedList list = new LinkedList();
	public Queue(){	
	}
	
	public boolean isEmpty(){
		return list.isEmpty();
	}
	
	public void enqueue(int _data){
		list.pushTail(_data);
	}
	
	public int dequeue(){
		Node node = list.popHead();
		if(node == null) throw new NullPointerException();
		return node.data;
	}
	
	
}

package ex11;

class MyClass {

	@Override
	public String toString() {
		return "MyClass";
	}

}

public class Ex05 {

	static int doA() {
		return 10;
	}

	static MyClass doClass() {
		return new MyClass();
	}

	public static void main(String[] args) {
			MyClass mc = new MyClass(); // mc는 MyClass를 인스턴스화한것 // return "MyClass" // "MyClass" 를 반환
			System.out.println(mc);
	}

}

package ex14;

public class AA {
	
	//오버로딩 기법
	public int doC() { // 반환되는 거라 return 필수
		System.out.println("AA doA");
		return 10;
		//클래스 안에는 변수 메서드가 가능하지만
		//메서드안에는 메서드 불가능
	}
	
	public void doA() {
		System.out.println("AA doA");
	}

	public void doA(int a, int b) {
		System.out.println("a = " + a);
		System.out.println("b = " + b);
	}

	public void doA(String c) {
		System.out.println("c = " + c);
	}
	public static void doB() {
		System.out.println("AA doA");
	}

	public static void doB(int a, int b) {
		System.out.println("a = " + a);
		System.out.println("b = " + b);
	}

	public static void doB(String c) {
		System.out.println("c = " + c);
	}
}

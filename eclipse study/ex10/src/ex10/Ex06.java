package ex10;

// 생략되어진 표현
// import.java.lang*;
// 기본생성자


public class Ex06 {
	
	// 생성자와 메서드는 조금 다르다
	// 생성자는 리턴되는 값이 안적혀져 있다
	// 매서드는 리턴되는 값이 적혀져 있다
	
	// 클래스 함수는 인스턴스화 해야지만 사용할 수 있다.
	public void doA(){ // 다른 곳에서 불러올려면은 public을 붙여야 한다. // 안 붙이면 해당 클래스에서만 사용 가능
		System.out.println("doA 메서드 입니다.");
	}
	// static은 메모리 공간에 항상 상주한다..
	public static void doB(){ 
		System.out.println("doB 메서드 입니다.");
	}
	
	// alt + shift + s -> c 누르면 기본생성자 만들기	
	 public Ex06(){ // 생성자
		System.out.println("기본 생성자..");
	}
	
	public static void main(String[] args) {
		
		//new Ex06();
		Ex06 ex06 = new Ex06();
		ex06.doA();
		
		//Ex06.doA();
		Ex06.doB(); // static 함수
		
		System.out.println();
	}

}

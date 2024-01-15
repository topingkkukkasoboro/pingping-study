package ex10;

public class Ex09 {
	
	//기본 생성자
	// static 함수 static 변수
	// 클래스 생성 인스턴스화, 메모리에 올린다
	
	
	Ex09(){
		System.out.println("기본생성자");
	}
	
	public static void doA() {
		System.out.println("static 함수");
	}
	public void doB() {
		System.out.println("non-static 함수");
	}
	
	public static void main(String[] args) {
		
		
		//doB();  // static 함수가 아니기때문에 호출안됨
		//Ex09.doB(); // static 함수가 아니기때문에 호출안됨
		
		
		doA(); // static 함수 호출
		Ex09.doA(); // static 함수 호출
		
		Ex09 ex09 = new Ex09(); // 기본 생성자
		ex09.doA();// 참조 변수를 통해서 static 함수 호출
		
		ex09.doB(); // static 함수가 아니기 떄문에 참조 변수를 통해서 호출해야한다
	}

}

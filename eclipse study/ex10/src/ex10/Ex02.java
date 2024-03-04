package ex10;

/*
 * tv라는 객체를 클래스로 만들도록 한다
 * 속성과 기능
 * 속성은 변수, 메서드로 구성
 */

//class Tv {// Tv라는 클래스
//
//	String color; // tv의 색상 // 변수
//	boolean power; // tv의 전원상태(on/off) // 변수
//	int channel; // tv의 채널 // 변수
//	
//	Tv(){}; // 생성자 호출
//	
//	void power() { // power 함수
//		System.out.println("power버튼 누름");
//		power = ! power; // power에 넣는다 // false가 아니다를 넣는다 // 비교가 아니다
//		// =!가 아닌 !power이다
//	}
//	
//	void channelUp(){System.out.println("채널 올리기");channel++;}
//	void channelDown(){System.out.println("채널 내리기");
//	channel -=1;
//	if(channel == -1) 
//		System.out.println("채널이 음수라서 0으로 초기화");
//	channel =0;
//	}
//	}

public class Ex02 {
	public static void main(String[] args) {
		
		Tv tv1 = new Tv(); // Tv 클래스에 tv1을 메모리에 올린다 // 인스턴스화한다
		//Tv 클래스의 인스턴스를 생성하고 tv1에 할당한다
		System.out.println(tv1.color); // 초기값 null
		System.out.println(tv1.power); // 초기값 flase
		System.out.println(tv1.channel); // 초기값 0
		
		tv1.power();
		
		System.out.println(tv1.power); // void power에서 변경된 power상태를 출력
		tv1.channelDown();
		System.out.println(tv1.channel);
		tv1.channelUp();
		System.out.println(tv1.channel);
		//tv1 = null; // java에서 자동으로 정리해준다
	
}
}

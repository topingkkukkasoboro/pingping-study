package ex10;

public class Tv {
	public String color; // tv의 색상 // 변수
	public boolean power; // tv의 전원상태(on/off) // 변수
	public int channel; // tv의 채널 // 변수
	
	Tv(){}; // 생성자 호출
	
	public void power() { // power 함수
		System.out.println("power버튼 누름");
		power = ! power; // power에 넣는다 // false가 아니다를 넣는다 // 비교가 아니다
		// =!가 아닌 !power이다
	}
	
	public void channelUp(){System.out.println("채널 올리기");channel++;}
	public void channelDown(){System.out.println("채널 내리기");
	channel -=1;
	if(channel == -1) {
		System.out.println("채널이 음수라서 0으로 초기화");
	channel =0;
	}
}
}


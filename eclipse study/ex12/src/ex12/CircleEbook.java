package ex12;
/*
 * 변수      매서드
 * 반지름설정 원 넓이 계산
 * public으로 선언하는것은 모든 곳에서 호출가능하다
 */

public class CircleEbook {

	
	// 다른 클래스에서 이 변수 참조 불가입니다.
	private int rad;
	
	//fianl을 넣었기에 변경불가
	final double PI = 3.14;
	
	
	public CircleEbook() {}
	
	public CircleEbook(int rad) {
		this.rad = rad;
	}

	
	public void setRad(int r) {
		if(r < 0){this.rad = 0; return;}
		this.rad = r;
	}


	public double getArea(){
		return rad *rad * PI;
	}
	
}

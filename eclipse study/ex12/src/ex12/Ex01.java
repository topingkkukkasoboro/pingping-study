package ex12;

// 생성자
// 매서드
// 밑변과 높이를 지정할수 있는 생성자
// 밑변과 높이로 넓이를 구하는 매서드
// 복습한다.
//클래스내에서는 여러 생성자를 선언할 수 있다.
//클래스 내에서는 클래스 변수와 클래스 매서드를 선언할 수 있다.



public class Ex01 {

	public static void main(String[] args) {

		// 기본생성자 호출해서 클래스를 메모리에 올림 // 인스턴스화
		Tri t1 = new Tri(10, 20);
		Tri t2 = new Tri();

		System.out.println(t1);
		System.out.println(t2);
		
		System.out.println(t1.area());
		System.out.println(t2.area());
	}

}

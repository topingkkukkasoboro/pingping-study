package ex10;

class AA{
	int a = 10;
	static int b = 20; // static변수 // 공유변수// 프로그램 시작과 동시에 초기화해서 프로그램 끝날때까지 공유되는 변수..
	//많이 사용하는 변수는 static으로 //적게 사용하면 클래스변수나 인스턴스변수
}

public class Ex05 {
	
	public static void main(String[] args) {
		AA a1 = new AA(); // 객체 생성해서 참조
		AA a2 = new AA();
		
		a1.a++;
		System.out.println(a1.a); // 11
		System.out.println(a2.a); // 10
		
		AA.b++;
		System.out.println(AA.b);
		System.out.println(a2.b);
	}

}

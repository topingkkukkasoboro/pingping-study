package ex04;

public class Ex02 {

	public static void main(String[] args) {
		boolean a = true;
		boolean b = !a;
		
		System.out.println("a = " + a);
		System.out.println("b = " + b);
		
		int c = 10;
		int d = 20;
		
		System.out.println("c = " + c);
		System.out.println("d = " + d);
		
		d += c;// d = d + c라는 뜻 오른쪽을 먼저 계산한다
		System.out.println("d = " + d);
	}
}

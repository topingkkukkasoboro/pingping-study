package ex05;

public class Ex05 {
	public static void main(String[] args) {
		int a = 10;
		int b = 20;
		boolean c = a>b && b> (b=30); // boolean은 참과 거짓을 구분하는 논리값을 구한다 // 논리 값이라는 참과 거짓 구분하는것
		// b > b가 오른쪽의 값이냐 ? (b=30) b = 20임으로 false 
		
		System.out.println(c);
		System.out.println(b);
		
		boolean d = a<b || b> (b=30);
		
		System.out.println(d);
		System.out.println(b);
		
		boolean e = a<b && b> (b = 30);
		
		System.out.println(e);
		System.out.println(b);
	}

}

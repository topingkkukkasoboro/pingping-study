package ex05;

public class Ex05 {
	public static void main(String[] args) {
		int a = 10;
		int b = 20;
		boolean c = a>b && b> (b=30); // boolean은 참과 거짓을 구분하는 논리값을 구한다 // 논리 값이라는 참과 거짓 구분하는것
		// b > b가 오른쪽의 값이냐 ? (b=30) b = 20임으로 false

		// c의 정의는 a가 b보다 크면서 b값이 30이라면 true 하나라도 틀리거나 둘 다 틀리면 false // and로 생각
		
		System.out.println(c); // c는 false
		System.out.println(b); // b는 20
		
		boolean d = a<b || b> (b=30); // d의 정의는 a보다 b가 크거나 b가 30일때 하나라도 맞으면 true // 둘다 틀리면 flase // or로 생각
		
		System.out.println(d); // d는 true
		System.out.println(b);
		
		boolean e = a<b && b> (b = 30); // e의 정의는 a보다 b가 크면서  b 값이 30이면 true 하나 혹은 둘다 틀리면 flase // 둘다 참이여야함
		
		System.out.println(e);
		System.out.println(b);
	}

}

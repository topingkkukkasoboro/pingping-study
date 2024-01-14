package ex02;

public class Ex05 {

	public static void main(String[] args) {
		// int double String boolean 4개기억 하도록 합시다..
		// boolean은 참과 거짓을 구분해주는 논리연산자이다
		boolean a = true;  // boolean에 a에 true를 넣으면 a는 참으로 나온다
		boolean b = false; // boolean에 b에 false를 넣으면 b는 거짓으로 나온다
		
		boolean c = false;
		
		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
		
		System.out.println(10<20); // 10보다 20이 크냐를 구분해준다 ""가 있었으면 그대로 문장이 나왔겠지만
		System.out.println(30<20); // 두개다 거짓임으로 flase가 출력된다
		
		byte k = (byte)128; 
		System.out.println(k); // byte의 범위는 -128부터 127까지 // k에 넣은 값이 초과되어 최소값인 -128로 출력
		
		
	}
}

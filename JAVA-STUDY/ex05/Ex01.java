package ex05;

import java.util.Scanner;

class A{
	public void doA(){}
}

public class Ex01 {
	
	public static void main(String[] args) {
		int b;
		b = 10;
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		String result = n%2 ==0 ? "n is even" : "n is odd";
		// 삼항연산자 // 말그대로 항이 3개 // n%2 ==0 이걸 조건으로 본다 //앞에 걸로 우짜라고 ? 참과 거짓으로 구분해야겠네
		// 그래서 참이면 "n is even"//  참이 아니면 : //다른값 즉 아니라면  "n is odd"이다
		System.out.println(result);
		
	}

}

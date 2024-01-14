package ex06;

import java.util.Scanner;

public class Ex06 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		String temp = sc.nextLine();
		// 안녕하세요 입력해볼게요
		// String이니까 nextLine으로
		
		System.out.println(temp.charAt(0));
		System.out.println(temp.charAt(1));
		System.out.println(temp.charAt(2));
		
		String[]ar = {"ㄱ","ㄴ","ㄷ","ㄹ","ㅁ"}; // 구분은 "",로 가능 // 
		
		//숫자를 0부터 시작하는걸로 외우자
		System.out.println(ar[0]); //temp의 0번째 문자를 출력 
		System.out.println(ar[1]); // temp의 1번째 문자를 출력
		System.out.println(ar[2]); // temp의 2번째 문자를 출력
		System.out.println(ar[3]); // temp의 3번째 문자를 출력
		System.out.println(ar[4]); // temp의 4번째 문자를 출력
		
		String c ="10 20 30 40"; //""안에 넣어서 띄워쓰기로 구분 가능 //
		String test[] = c.split(" ");// ""를 기준으로 잡았기 때문에 가능하다
		System.out.println(test[0]);
		System.out.println(test[1]);
		System.out.println(test[2]);
		System.out.println(test[3]);
		
}

}

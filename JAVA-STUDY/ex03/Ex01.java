package ex03;

import java.util.Scanner;

/*
 * string 5
 * stringstringstringstringstring
 * 제어문...
 * ctrl + / 주석 설정 및 해제 
 * ctrl + shift + c 주석 설정 및 해제
 */
public class Ex01 {
	public static void main(String[] args) {
		// 참조 변수 선언
		Scanner scan = new Scanner(System.in);
		// 문자열 입력 출력해라
		//System.out.println("문자열 입력");
		// 입력 받아라... next 함수는 빈공백 String 5 
		//String str = scan.next();
		//System.out.println("반복횟수 입력");
//		int n = scan.nextInt();
//		System.out.println("str = "+str);
//		System.out.println("n = "+n);

		/*
		 * i = 0 일때 for구문 안에 잇는거 반복해라
		 */
		for (int i = 0; i< 5 ; i=i+2) { // i가 0일때 ; i가 5미만이면 i에 2씩 더해라 //  i가 5보다 작지않으면 // 크면 반복안한다 
			System.out.println(i);
		}
		System.out.println("일로 옵니다.");
	}
}

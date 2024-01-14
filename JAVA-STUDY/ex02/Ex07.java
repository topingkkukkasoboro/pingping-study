package ex02;

import java.util.Scanner;

// 7장 가면 자세히 할꼐요...
class AA{
	public void doA() {
		System.out.println("AA.doA()"); 
	}
}

public class Ex07 {

	public static void main(String[] args) {
		// 기본형
		int a= 10;
		// 참조형 타입 변수 선언
		Scanner scan = new Scanner(System.in); // 스캐너는 입력한것을 말그대로 스캔해서 받는다
		System.out.println("입력 하세요 ! ");
		
		String inputString = scan.nextLine(); //문자열을 스캔해서 inputstring에 넣어라 // String 스캔방식
		System.out.println(inputString); // 출력하면 inputstring에 스캔하여 넣은 값을 출력
		
		// 참조형 타입 변수 선언
		AA aa = new AA();
		aa.doA(); // 나아중에 이게 뭔지 배울거에요
//		scan.

	}
	
}

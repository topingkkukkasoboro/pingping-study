package ex07;

import java.lang.*; // 생략가능한

//void의 뜻은 비어 있다

public class Ex02 {
	
	public static void doA() { // ()가 비면 매게변수가 없다
		System.out.println("doA 매게변수 없는 함수");
		return; // 함수 종료
	}
	public static void doB(int a) {//()안에 있으므로 매게변수가 있다 a
		System.out.println("doA 매게변수 a = " +a);
		if(a==10) {
		return;
		}
		else if(a==8){
			System.out.println("종료됩니다");
			return;
		}
		System.out.println("if구문 else구문을 못갔다..");
	}
	//void String int boolean char
	public static int doC(int a) {
	return a*a;
	}
	
	//alt + <- 화살표 왼쪽 방금 전 작업소스
	//alt + -> 화살표 오른쪽 방금후 작업소스
	public static void doD() {
		String a = "abcdef";
		System.out.println(a.substring(3)); //3번째부터 잘라라 // 0부터 세려라
		System.out.println(a.substring(3,5)); // 3번부터 5번전까지 잘라라(3,5니까 3번에서 5번전까지 3,4)
	}
	
	public static void main(String[] args) {
		doA(); // 수행문
		doB(7); // 수행문
		//int a = doC(10);
		System.out.println(doC(10));
		System.out.println(doC(20));
		System.out.println(doC(30));
		doD();
	}

}

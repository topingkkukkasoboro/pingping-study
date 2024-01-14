package ex03;

import java.util.Scanner;

/*
 * 입력받은 n 만큼 str 값을 출력해라...
 */

public class Ex02 {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

		System.out.println("문자열 입력"); // 문자열 입력 출력
		String str = scan.next(); // str을 string형으로 스캔받자
		
		System.out.println("반복횟수 입력"); // 반복횟수 입력 출력
		int n = scan.nextInt(); // n을 int형으로 스캔받자
		
		System.out.println("str = " + str); // str =  str
		System.out.println("n = " + n);// n = n
		
		for (int i=0; i<n;i++) { // i가 0일때 / i가 n보다 작을동안 / i에 1씩더해라
			System.out.println(str); //str을 출력해라
		}
	}

}

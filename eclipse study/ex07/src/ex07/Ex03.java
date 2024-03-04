package ex07;

import java.util.Scanner;

public class Ex03 {
	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		
		for(int i=0;;i++ ) { // 조건이 없기 떄문에 무한대로 작성됨..
			String temp = sc.nextLine(); // temp의 문자열을 스캔
			
			if(temp.equals("0 0")){ // 만약에 temp에 있는게 0 0과 같다면
				System.out.println(""); // 종료됩니다를 출력해라
				break; // 빠져 나와라
			}
			
			int num1 = Integer.parseInt(temp.split(" ")[0]);
			int num2 = Integer.parseInt(temp.split(" ")[1]);
			
			//System.out.println("num1 = " + num1);
			//System.out.println("num2 = " + num2);
			System.out.println(num1 + num2);
			//System.out.println(temp);
			
		}
	}

}

package java_class;

import java.util.Scanner;

public class Ex02 {
	public static void main(String[] args) {
	
		Scanner scan = new Scanner(System.in);
		
		
		System.out.println("문자열 입력");		
		String str = scan.next();
		
		System.out.println("반복횟수 입력");
		int n = scan.nextInt();
		
		System.out.println("str = " +str);
		System.out.println("n = "+n);
		
		for(int i = 0;i<n;i++);
		System.out.println(str);
	}

}

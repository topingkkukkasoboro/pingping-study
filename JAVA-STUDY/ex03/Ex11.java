package ex03;

import java.util.Scanner;

public class Ex11 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String a = sc.next();
		char str[] = a.toCharArray();
		char test1 = 'z';
		char test2 = 'Z';
		char test3 = 'a';
		char test4 = 'A';
		for (int i = 0; i < str.length; i++) { //i가 0일때 str의 길이보다 작다면 i에 1씩 더해라
			if (str[i] > 90) // 배열str의 i번째가 90보다 크면
				str[i] = (char) ((int) str[i] - 32);  // str의 i번째는 str배열의 i번째를 int로 형변환하고 
			                                         //-32한뒤 문자로 형변환
			else
				str[i] = (char) (int) (str[i] + 32);// str의 i번째는 str배열의 i번째를 int로 형변환하고 
                                                    //-32한뒤 문자로 형변환
		}
		System.out.println((int) test1);
		System.out.println((int) test2);
		System.out.println((int) test3);
		System.out.println((int) test4);

		System.out.println(new String(str));
	}
}

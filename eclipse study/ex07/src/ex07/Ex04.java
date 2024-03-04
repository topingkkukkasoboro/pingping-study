package ex07;

import java.util.Scanner;

public class Ex04 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int rowNum = sc.nextInt();
		
		for(int i = 0; i < rowNum; i++) { // i가 0일때 i가 rowNum보다 클때까지 i에 1씩 더해라

			for(int j = 0; j < i +1 ;j++) { // j가 0일때 j가 i보다 클떄까지 j에 1씩 더해라

				System.out.print("*");
		}
			System.out.println();
	}
	}
	}

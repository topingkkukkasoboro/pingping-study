package ex01;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int[]a = new int[30];
		int[]number = new int[28];
		int b = 0;
		 
		
		for(int i = 0; i < 28; i++) {
			a[i] = sc.nextInt();
			number[i] += a[i]; //저장소
		}
	 
			for(int j = 0; j < 28; j++) {
				int i =0;
				while(i == number[j]) {
					i++;
					if( i == number[j]) {
						i = 0;
					}else {
						b += i;
					}
				} 
			}
			System.out.println(b);
			
	}
}
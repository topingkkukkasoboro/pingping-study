package ex04;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
	      
	      String str = scan.nextLine(); // String str을 스캔
	      String [] numbers = str.split(" "); // 스트링 배열 numbers에 배열 str의 하나씩 넣어라 // numbers의 최대는 2 즉 3자리
	      long A = Long.parseLong(numbers[0]); // numbers 배열 0번재를 long타입으로 형번환하여 A에 넣자
	      long B = Long.parseLong(numbers[1]);
	      long C = Long.parseLong(numbers[2]);
	      
	      System.out.println(A+B+C);
	      
	   }
	}
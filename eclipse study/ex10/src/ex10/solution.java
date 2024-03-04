package ex10;

import java.util.Iterator;

public class solution {

	public solution() {
		// 프로그램 시작과 동시에 메모리에 상주된다
		String num = "78720646226947352489";
		solution(num);
	}

	public int solution(String number) {
		int answer = 0;
		char[] arr = number.toCharArray();
		int[] brr = new int[arr.length];
		
		int sum = 0;

		for (int i = 0; i < arr.length; i++) {
			brr[i] = arr[i] - 48;
		}
		for (int i = 0; i < arr.length; i++) {
			sum = sum + brr[i];
		}
		answer = sum%9;
		System.out.println(answer);
		return answer;
	}

	public static void main(String[] args) {
		new solution(); // heap 영역
	}
}

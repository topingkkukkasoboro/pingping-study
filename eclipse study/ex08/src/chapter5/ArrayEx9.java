package chapter5;

import java.util.Arrays;

class ArrayEx9 {
	public static void main(String[] args) {
		int[] code = { -4, -1, 3, 6, 11 }; // 코드 배열의 요소
		int[] arr = new int[10]; // arr은 10자리 배열

		for (int i=0; i < arr.length ; i++ ) { // i = 0부터 9까지 동작합니다
			int tmp = (int)(Math.random() * code.length); // tmp에는 랜덤값 곱하기 코드 배열의 길이
			arr[i] = code[tmp];
		}

		System.out.println(Arrays.toString(arr));
	} 
}

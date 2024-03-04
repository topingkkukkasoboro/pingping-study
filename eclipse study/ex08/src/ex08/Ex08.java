package ex08;

import java.util.Arrays;

public class Ex08 {
	public static void main(String[] args) {
		int[] arr = {1,2,3,4,5,6,7,8,9};
		int[] brr = arr; // arr이랑 brr의 배열은 같다
		
		arr[0] = 100; // arr의 0번째 숫자는 = 100으로 바꿔라
		
		System.out.println(Arrays.toString(arr)); // arr의 배열을 출력?
		System.out.println(Arrays.toString(brr)); // brr의 배열을 출력?
		
	}

}

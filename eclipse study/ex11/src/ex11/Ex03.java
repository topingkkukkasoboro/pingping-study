package ex11;

// 배열을 선언하고
// 배열을 정렬하고
// 배열의 모든값을 더해서 출력해보기..
// 메서드르 이용해서

import java.util.Arrays;

public class Ex03 {

	Ex03() {
		int arr[] = new int[] { 10, 20, 5, 2, 11 };

		ArrayU myU = new ArrayU(); // class ArrayU를 myU로 인스턴스화
		myU.sort(arr); // myU에 있는 sort의 arr
		myU.print(arr); // myU에 있는 print의 arr
	}

	public static void main(String[] args) {
		new Ex03();
	}

}

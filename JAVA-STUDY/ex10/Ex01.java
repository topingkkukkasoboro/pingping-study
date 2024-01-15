//		System.out.println(arr[0][0]); // 배열의 초기값을 0으로 선언
//		System.out.println(arr[0][1]); // 즉 0만 나옴
//		System.out.println(arr[0][2]); // 각 자리는 0이기에 수를 넣어주면 된다
//		System.out.println(arr[0][3]); 		

package ex10;

/*
 * 5*5 배열에다가
 * 랜덤한 숫자르 넣어 출력해보기(1~100)
 * 프로그래밍 언에에서는 소스의 중복이 좋지 않다
 */
public class Ex01 {// 메써드는 클래스내에 있으면 된다

	public static void doprintArr(int[][]arr) { // main에서 가져온다

		for (int i = 0; i < arr.length; i++) { // arr의 길이만큼
			for (int j = 0; j < arr[i].length; j++) {
				// 0 < x < 100
				arr[i][j] = (int) (Math.random() * 100) + 1; // 데이터형을 맞춰야하기 떄문에 앞에 (int)or(double)를 선언해야한다
			}
		}

		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = (int) (Math.random() * 100) + 1;
				System.out.print(arr[i][j] + "\t");

			}
			System.out.println();
		}

	}

	public static void main(String[] args) {

		int[][] arr = new int[5][5]; 
		int[][] brr = new int[5][5];

		doprintArr(arr); // doprintArr으로 데려간다
		doprintArr(brr);
		
	}
}
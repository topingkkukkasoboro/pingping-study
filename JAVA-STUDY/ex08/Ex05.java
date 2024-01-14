package ex08;

public class Ex05 {
	public static void main(String[] args) {
		// i = 0일때 j는 0에서 9까지
		
		//k = 0일때 i = 0일때 j = 0~9
		for (int k = 0; k < 10; k++) // k가 10이될때까지 k에 1씩더해라
			for (int i = 0; i < 10; i++) { //// i가 10이될때까지 i에 1씩더해라
				System.out.println("i = " + i); // i = 0
				
				for (int j = 0; j < 10; j++) { // j가 10이될때까지 j에 1씩더해라

					if (j == 3 || j == 6 || j == 9) { // j가 3이거나 6이거나 9중 하나이면 참
						continue; // 넘어가라
					}
					if (j == 7) { // j가 7과 같을때까지
						i++; // i에 1씩 더해라
						System.out.println("여기 왔냐"); // 여기 왔냐
						break; // aa 시마이
					}
					System.out.println("\t j=" + j); // j = 0등등
				}
			}
	}

}

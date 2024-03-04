package ex09;

import java.util.Arrays;

/*
	 * 버블정렬 알고리즘
	 * {100,90,60,40,120}  // 맨앞에 수와 두번째 수를 비교해서 더 작은 수를 앞으로 더큰 수를 뒤로
	 * {90,100,60,40,120}  // 100과 90을 비교 했을때 90이 100보다 작으므로 앞으로 이동
	 * {90,60,100,40,120}  // 두번째 100과 60을 비교 60이 더 작으므로 앞으로 이동
	 * {90,60,40,100,120}  // 1회전 했다 (120은 제일 큰수로 냅둠) // 2회전때는 앞에서부터 4개만
	 *  2회전시작
	 *  {60,90,40,100,120}
	 *  {60,40,90,100,120} // 100이 제일 큼으로 뒤에 두고 2회전 끝
	 *  3회전 시작
	 *  {40,60,90,100,120} // 90이 제일 큼으로 끝
	 * 
	 * 요소중 제일 큰수
	 * 요소중 제일 작은수
	 * 
	 * 내림차순
	 * 120, 100, 90, 60, 40
	 * 오름차순
	 * 40, 60, 90, 100, 120
	 */
public class Ex04 {
	
	public static void main(String[] args) {
		
		int[] arr = {100, 90, 60, 40, 120};
		
		for(int i = 0 ; i < 5 - i; i++) {
			for(int j = 0; j < 5 - j ; j++) {
				if (arr[j] > arr[j+1]){
					
					int temp = arr[j];
					
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
				}
			}
		}
	
		System.out.println(Arrays.toString(arr));
	}
}
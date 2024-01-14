package ex09;

public class Ex02 {

	public static int solution(int[] num_list) {
		int answer = 0;
		
		int rhq = num_list[0];
		int gkqdmlwprhq = 0;
		
		//i는 0부터 배열의 길이만큼 반복한다
		for (int i = 1; i < num_list.length; i++) {
			rhq = num_list[i];
			gkqdmlwprhq += num_list[i];
		}
		
		System.out.println(rhq);
		System.out.println(gkqdmlwprhq * gkqdmlwprhq);
		
		if(rhq > gkqdmlwprhq * gkqdmlwprhq) 
			answer = 0;
			else
				answer = 1;
		
		
		return answer;
	}
	public static void main(String[] args) {
		
		//int[]num_list = {3,4,5,2,1};
		int[]num_list = {5,7,8,3};
		solution(num_list);
		
	}
}

package ex03;

/*
 * int -> char unicode A =>65 65=>A
 * 
 * 실수 -> 정수
 * double -> int 소수점을 버려서 형변환됩니다.
 * 
 *  정수 -> 실수
 *  10 -> 10.0
 *  20 -> 20.0
 */
public class Ex09 {

	public static void main(String[] args) {
		double d = 833.833d;
		int score = (int) d; // 더블 d를 int형으로 변경 // int는 소수점 자리가 나올수 없음으로 소수점 자리가 소실된다
		System.out.println("score = "+score);
		System.out.println("d = "+d);
		
		// 비트 체계가 작은거에서 큰걸로 바꿀때는 자료의 소실이 
		// 없기 때문에 안적어도 자동 형변환 됩니다.
		int aa = 10;
		double ee = aa; // aa는 int형이지만 더블형으로 변환하면 소수점이 나온다. 10이라고 딱 주어졌음으로 10.0
		System.out.println("aa = "+ aa);
		System.out.println("ee = "+ ee);
	}
}

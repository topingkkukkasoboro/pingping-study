package java_class;

public class Ex09 {
	
	//int -> char unicode A => 65 65 => A
	
	//실수 -> 정수
	//double -> int 소수점을 버려서 형변환됩니다.
	
	//정수 -> 실수
	//10 -> 10.0
public static void main(String[] args) {
	double d = 85.4d;
	int score = (int) d;
	System.out.println("score = " + score);
	System.out.println("d =" + d);
	
	// 비트 체계가 작은거에서 큰걸로 바꿀때는 자료의 손실이 없기 때문에 안적어도 자동 형변환 됩니다.
	// 소수점이 사라지기 때문에 int는 형변환 적어야함 ex) (int)
	// ctrl + 1 하면 형변환 선택 가능
	int aa = 10;
	double ee =aa;
	System.out.println("aa = " +aa);
	System.out.println("ee = " +ee);
}
}

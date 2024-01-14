package ex03;

public class Ex08 {

	// 1byte -128 ~ +127
	
	public static void main(String[] args) {
		char aa = 'A'; // 문자 aa는 A
		System.out.println(aa); // aa출력
		int bb = (int) aa; //정수 bb는 문자aa에 있는 값을 int로 형변환 
		System.out.println(bb); //bb 출력
		char cc = (char) bb; // 문자 cc는 bb를 문자로 형변환
		System.out.println(cc); // cc출력
		
		byte kk = 127;
		System.out.println(kk+1);		// int형 연산... 
		System.out.println((byte)(kk+1));	// 오버플로우 8bit 
	}
}

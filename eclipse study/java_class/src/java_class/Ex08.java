package java_class;

public class Ex08 {
	public static void main(String[] args) {
		
		//1byte -128 ~ +127
		
		char aa = 'A';
		System.out.println(aa);
		int bb = (int)aa;
		System.out.println((int)bb);
		char cc = (char) bb;
		System.out.println(cc);
		
		byte kk = 127;
		System.out.println(kk+1); // 자체적으로 int형 연산
		System.out.println((byte)(kk+1)); //오버플로우 8bit
	}

}

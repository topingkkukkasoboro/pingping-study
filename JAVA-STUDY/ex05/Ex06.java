package ex05;

public class Ex06 {
	public static void main(String[] args) {
		
		int a = 10;
		//a = 1010 2진수로 바꾸면
		// a >> 2 비트가 두칸 가게 되면 -> 0101 -> 0010 오른쪽으로 가게 되며 빈 자리는 0으로 메꾼다
		//0010
		
		System.out.printf("%x\n",a); // printf 사용했을떄 %x는 , 뒤에 있는 문자를 넣는다 넣는 위치에 맞춰서 넣으면 된다
		System.out.printf("%d\n", a>>2); // %d는 숫자 // \n은 줄 바꿈
		System.out.printf("%d\n", a>>2 & a);
	}

}

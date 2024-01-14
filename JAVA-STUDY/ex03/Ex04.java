package ex03;


class AA{
	public void doA() {
		System.out.println("doA");
	}
}

public class Ex04 {

	public static void main(String[] args) {
//		Integer i = new Integer(10);
		System.out.println(Integer.toBinaryString(10)); // 십진수를 2진수로 변환한다.
		AA a2 = new AA(); // AA선언하고 a2로 선언하고 정의하자 즉 초기화
		a2.doA(); // a2를 빌려온다
		
		String a = new String("abcd");
		System.out.println(a.toUpperCase()); // 소문자를 대문자로 변형
	}
	
}

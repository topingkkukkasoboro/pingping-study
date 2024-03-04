package ex05;

public class Ex04 {
	public static void main(String[] args) {
		String a = "abc";
		String b = "abc";
		
		System.out.println(a==b); //a랑b가 같냐
		
		String c = "abc";
		String d = new String("abc"); //new String으로 새롭게 선언가능
		System.out.println(d);
		System.out.println(c==d);// new String으로 선언한것과 String으로 선언한건 다르다
		System.out.println();
		System.out.println(c.equals(d)); // 문자열 비교연산자는 equals() // equals()로는 문자를 비교하기에 맞다고 나온다
	}

}

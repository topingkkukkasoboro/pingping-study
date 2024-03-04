package ex14;

public class Ex05 {
	
	public static void main(String[] args) {
		String a = "abc";
		String b = "def";
		
		System.out.println(a+b);
		System.out.println(a.concat(b)); // + 나 concat은 똑같다
		
		System.out.println(a.substring(1));
		System.out.println("abcdef".substring(0,4));
		
		String c = "abcdefg";
		String d = "abcdefg";
		
		System.out.println(c.compareTo(d)); // comopareTo 비교해준다
		System.out.println("A".compareTo("B")); // 다른만큼 숫자로 표기
		System.out.println("B".compareTo("A"));
		
	}

}

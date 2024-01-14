package ex05;

public class Ex03 {
	public static void main(String[] args) {
		char lowercase = 'a';
		char uppercase = (char)(lowercase - 32);
		
		System.out.println((int)'a');
		System.out.println((int)'A');
		
		//유니코드에서 대문자가 소문자보다 32가 작다
		
		char z = 'z';
		System.out.println(z);
		System.out.println((char)(z-32));
		
		System.out.println(uppercase);
	}

}

package ex03_1;

public class Ex02 {

	public static void main(String[] args) {
		// && || ! & | ^ ~

		int a = 10;
		int b = 20;
		int c = 30;

		// 입력받은 값이 a와 b 사이인지 확인하는 것 출력하세요
		// a<15<b
		int input = 15;
		System.out.println(a < input && input < b); // &&는 앞뒤 둘다 같은 경우 and
		
		// a > input || b > input
		// 최소 공배수 최대 공약수...
		// 30/2 ==? 0
		// 30을 5로 나누었을때 나머지가 0 or 30을 7으로 나누었을때 나머지 0
		System.out.println(30%5==0 || 30%7==0); // ||앞이 말이 맞거나 뒤에 말이 맞을때 하나만 맞으면 됨 or
		
		boolean aa = true;
		if(30%5==0 && 30%7==0) {
			System.out.println("aa 값은 참입니다");
		}
		else {
			System.out.println("aa 값은 거짓입니다.");
		}

	}
}

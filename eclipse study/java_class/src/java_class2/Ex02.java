package java_class2;

public class Ex02 {
	public static void main(String[] args) {
		// && || ! & | ^ ~
		
		int a = 10;
		int b = 20;
		int c = 30;
		
		// a<15<b
		//입력받은 값이 a와 b 사이인지 확인하는 것 출력하세요
		
		int input = 15;
		System.out.println(a < input && input <  b );
		//%%는 and 그리고라는 뜻
		
		//||는 or 혹은이라는 뜻
		//최소 공배수가 인가? 최대 공배수인가 (그게 뭔가요?)
		//30/2 ==? 0
		//질문 : 30을 5로 나누었을때 나머지가 0인가요?
		
		System.out.println(30%5==0 || 30%7==0);
		
		
		
		
		boolean aa = true;
		if(30%5==0 || 30%7==0) {
			System.out.println("aa의 값은 참입니다");
		}
		else{
			System.out.println("aa의 값은 거짓입니다");
		}
	}

}

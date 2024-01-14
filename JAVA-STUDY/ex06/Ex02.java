package ex06;

public class Ex02 {
	public static void main(String[] args) {
		int x = 0;
		
		if(x==0) { // x가 0과 같다면 해라 // x==0d의 정의가 나오고 뒤에 입니다를 붙여서 출력
			System.out.println( (x==0) + "입니다."); // 왜 빨간색이 뜨냐 (우선순위문제) {} 이거 꼭 확인할것
		}
		if(x!=0) { // x는 0이랑 다르냐?
			System.out.println("실행이 안됩니다"); // 실행 안된다 (참이 아니기떄문에 !맞지 않기 떄문에!)
		}
	}

}

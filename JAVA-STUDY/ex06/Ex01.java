package ex06;

public class Ex01 {
	public static int solution(int a, int b) {
		
		/*
		 *  int -> double
		 *  double -> int
		 *  
		 *  String -> int
		 *  Integer.parseInt(변수명);
		 *  
		 *  String -> double
		 *  Double.parseDouble(변수명);
		 *  
		 *  String -> float
		 *  Float.parseFloat(변수명);
		 */
		
		int result1 = Integer.parseInt(a + "" + b); // a + b는 15인데 가운데 ""를 같이 더했다 이런 경우에는 숫자 뒤에 숫자를 붙인다 123으로 나온다
		int result2 = Integer.parseInt(b + "" + a); // 이건 312로
		
		if(result1 < result2)
			return result2;
		else
			return result1;

	}
	public static void main(String[] args) {
	
		int a = 12;
		int b = 3;
		
		int result = solution(a,b);
		System.out.println(result);

	}
		
		
		
		
	}



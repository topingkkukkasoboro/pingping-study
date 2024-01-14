package ex01;

import java.util.ArrayList;
import java.util.List;

// 재생버튼
// 마우스 우클릭 Run as -> Java application
// ctrl + f11
public class Ex02 {

	public static void main(String[] args) {
		
		List<User> list = new ArrayList<User>();

		int a = 10; // int a = 10이라는 뜻은 a를 int형으로 10을 부여했다.
		System.out.println("a = "+ a); // 출력은 "a  = " 쌍따움표를 한거는 그대로 나오기 위한 문자열 출력방식
		//+ a는 a를 같이 더해서 출력하라는 뜻
		
		int b = 20; // 그러면 이건 b에 20을 int형으로 부여
		System.out.println("a + b = "+(a+b)); // 여기서 (a+b)는 a의 값과 b의 값을 더해라
		
		String c = "a"; // c에 문장을 넣는다 넣을떄는 ""를 꼭 사용해서 사이에 넣는다 "" <-
		String d = "b";
		System.out.println(c+d); // a랑 b는 문장이기에 값을 더할수가 없다 그래서 붙여서 나온다
		
		// a = 10
		// b = 20
	}
}
	

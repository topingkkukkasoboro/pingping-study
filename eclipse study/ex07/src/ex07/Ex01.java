package ex07;

public class Ex01 {
	public static String solution(String my_string, String overwrite_String, int s) {
		
		/*
		 * charAT()몇번쨰.. 
		 * toCharArray() 문자로 배열 만들어라 
		 * replace 대체하여라 
		 * split 분할해라 
		 * subString 문자열을 자르는 함수
		 * 매게변수 start 시작점부터 잘라라
		 * 매게변수 start,end start부터 end까지
		 * abcdef.subString(3)
		 */
		
		//my_string = Helloworld 길이 = 10
		//overwrite_string = lloworl
		//temp = Hellowerl
		// s =2
		String temp = my_string.substring(0, s) + overwrite_String;
		String answer = temp + my_string.substring(temp.length());
		System.out.println(answer);
		return answer;
	}

	public static void main(String[] args) {
		String answer = "";
		solution("HelloWorld", "lloworl", 2);
		System.out.println(answer);
		solution("program29b8uyp", "mers123", 7);
	}

}

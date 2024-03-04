package java_class;
//요구사항 : 실수는 소수 두번째자리까지만 보여주세요
// ex) 23.456 -> 23.45로 나오게

import java.util.Scanner;

public class Ex11 {
	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		System.out.println("숫자입력");
		
		//next()는 문자열입력 * 빈공백전까지
		//nextline은 문자열 한줄까지
		//next(int)는 정수입력
		//next(double)은 실수 입력
		
		double d = scan.nextDouble();
		
		System.out.println("d = " + d);
		// 45.45555로 들어왔다 100을 곱하자
		// 4545.555로 나온다 -> int로 형변환
		// 4545.555를 100.0으로 나눈뒤 다시 double로 형변환 ->45.45
		
		//double trans_d = (int)(d *100)/100.0;
		//System.out.println("trans_d = " + trans_d);
		
		
		System.out.println("trans_d = " + (int)(d *100)/100.0);
		
	}

}

package ex04;

public class Ex01 {
	public static void main(String[] args) {
	// 형변환, 연산자
		// 소스는 가독성이 제일 중요
		
	int a = 10;
	double b = 20.2d;//d는 적어도 되고 안적어도 된다
	
	System.out.println("a = " + a);
	System.out.println("b = " + b);
	
	int c = (int)b;// 강제 형변환이 필요(자료소실생김 // 소숫점자리 숫자가 날라가기 때문)
	double d = a; // 강제 형변환 필요 없음
	
	System.out.println("c = " + c);
	System.out.println("d = " + d);
	
	System.out.println(a==b);// 같은지 확인
	System.out.println(b==c);
	
	System.out.println(a==d);
	
	System.out.println(a==b || a==d);// 둘중 하나라도 같은지 확인
	System.out.println(a==b && a==d); // 둘중 두개 다 같은지 확인
	
	System.out.println( b==c && (a==b || a==d));// 여러개를 할 경우 괄호를 필수적으로
	// b는c와 같으면서 a랑 b가 같거나 a랑 d가 같으냐?
	System.out.println(a == b && a ==d);
		
	}

}
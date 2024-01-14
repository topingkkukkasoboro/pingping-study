package ex05;

public class Ex02 {
	public static void main(String[] args) {
		char a = 'a';
		
		int i = 0;
		for( ; i < 26; i++) {
			System.out.println(i+"\t"+a++);
		}
		
		a = 'A' ; // for구문에 있는건 구문이 끝나면 삭제된다 // 즉 i가 26이상이 되게 되면 i는 삭제 된다
		// 하지만 초기 값을 공백으로 두고 for 구문 밖으로 초기값을 잡아두면 for 구문이 끝나도 살아있다
		i = 0;
		for(; i < 26; i++) { // i는 0으로 선언 되어 있음으로 ;로 스킵가능하다 // i가 즉 25가 될때까지  출력을 반복
			System.out.println(i+"\t"+a++); // i값에다가 tab만큼 띄우고 a를 ++하자
	}
	a= '0';
	System.out.println((int)a); // a를 int형으로 형변환해서 출력
	   
	int b = 0;
	
	for(i = 0; i < 26; i++) { // a는 문자 0으로 초기화해뒀다 거기에 맞춰서 1씩증가
		System.out.println(i+"\t"+a++); 
	}


	}
}

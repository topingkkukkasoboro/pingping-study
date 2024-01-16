package ex11;

/*
 * 연락처 관리 프로그램
 */
public class Ex11 {
	
	public static void main(String[] args) {
		
		Person[] p = new Person[10]; //배열로 인스턴스화 // class Person을
		
		p[0] = new Person();// 인스턴스화한 p의 0번째 배열은 Person
		p[0].name = "홍길동"; // p의 0번쨰 배열의 name은 홍길동
		
		p[0].setPerson("이길동", "010-9946-2662", "남자", "탈모");
		// p의 0번쨰 배열은 set person
		
		System.out.println(p[0]);
		System.out.println(p[1]);
		System.out.println(p[2]);
		
	}

}

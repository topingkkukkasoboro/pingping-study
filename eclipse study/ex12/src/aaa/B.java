package aaa;

class A {
	int num = 10;
}

public class B extends A { // 상속했다 A한테 자식은 부모의 돈을 쓸수있다
	int num2 = 20;
	public void doNum() {
		System.out.println(num);

	}

}

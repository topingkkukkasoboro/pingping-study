package ex11;

/*import java.lang*; 생략
 *기본생성자
 *toString()
 */

public class Ex04 {
	public static void main(String[] args) {

		Data d1 = new Data(); // class Data를 인스턴스화한게 d1
		System.out.println(d1.toString());
		System.out.println(d1);

		Data d2 = copy(d1); // 카피함수로 이동 // 똑같은것을 바라보는것이 아닌 d2도 Data를 인스턴스화 시킨것이 된다

		System.out.println(d2);

		d2.x = 100;
		System.out.println("d1 = "+d1);
		System.out.println("d2 = "+d2);

	}

	static Data copy(Data d) {
		Data data = new Data(); //d2를 위해 객체생성을 다시한다
		return data;
	}

}

class Data {
	int x = 10;

	@Override
	public String toString() {
		return "Data [x=" + x + "]";
	}

}

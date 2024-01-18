package ex12;

public class Tri {

	int width;
	int height;

	public Tri() { // 기본 생성자 다시 작성
	}
	public Tri(int width, int height) { // 다른생성자를 만들면 기본생성자 생략불가(직접 적어줘야함)
		this.width = width;
		this.height = height;
	}
	@Override
	public String toString() {
		return "Tri [width=" + width + ", height=" + height + "]";
	}
// 넓이를 구하는 매서드
	public double area() {
		return width * height * 0.5;
	}
	
}

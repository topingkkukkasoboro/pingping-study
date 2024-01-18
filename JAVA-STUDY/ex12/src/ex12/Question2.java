package ex12;

class point {
	int xPos, yPos;

	public point(int xPos, int yPos) {
		this.xPos = xPos;
		this.yPos = yPos;
	}
	public void showPointInfo() {
		System.out.println("xpos = " + xPos + " ypos = " + yPos);
	}
}
class Circle{
	point p;
	int rad;
	Circle(point p, int rad){
		this.p = p;
		this.rad =rad;
	}
	public void showCirecleInfo() {
		p.showPointInfo();
		System.out.println("rad = " + rad);
	}
}

public class Question2 {

	public static void main(String[] args) {

		point p1 = new point(5, 10);
		//p1.showPointInfo();
		Circle c = new Circle(p1,(5));
		c.showCirecleInfo();
	}
}

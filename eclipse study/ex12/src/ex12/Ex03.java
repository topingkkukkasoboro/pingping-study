package ex12;

public class Ex03 {
	
	public static void main(String[] args) {
		
		CircleEbook c1 = new CircleEbook();
		c1.rad = 10;
		
		System.out.println(c1.rad);
		System.out.println(c1.getArea());
		
		CircleEbook c2 = new CircleEbook(20);
		System.out.println(c2.getArea());
		
		//c1.rad = -3;
		c1.setRad(-3);
	}

}

package ex12;

class CapA {
	public void take() {
		System.out.println("CapA 약먹음 기침 나음");
	}
}

class CapB {
	public void take() {
		System.out.println("CapA 약먹음 콧물 나음");
	}
}

class CapC {
	public void take() {
		System.out.println("CapA 약먹음 열 이제 안남");
	}
}

class ColdPatient {
	void takeA(CapA a) {
		a.take();
	}

	void takeB(CapB b) {
		b.take();
	}

	void takeC(CapC c) {
		c.take();
	}
	void takeAll(CapA a, CapB b, CapC c) {
		a.take(); b.take(); c.take();
	}
}

public class Ex05 {

	public static void main(String[] args) {
		 ColdPatient cp = new ColdPatient();
		cp.takeAll(new CapA(), new CapB(), new CapC());
	}

}

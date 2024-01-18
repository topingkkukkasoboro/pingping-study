package ex13;

class Instclass{
	static int num = 0; // 다 같이 쓰는 공유 변수
	
	Instclass(){
		num++;
		System.out.println("생성자 호출" + num);
	}
}

public class Ex01 {
	public static void main(String[] args) {
		
		Instclass.num = 10;
		
		new Instclass();
		new Instclass();
		new Instclass();
		
		System.out.println(Instclass.num);
	}
}

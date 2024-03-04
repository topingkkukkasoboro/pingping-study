package ex07;

public class aa {
	public static void main(String[] args) {
		
		aa:for(int a = 0; a < 5; a++) { // aa:는 라벨 표시
		for(int i = 0; i < 5; i++) {
			
			if(i==2)
				continue aa; // i가 2가 나왔을떄는 통과 즉 그것만 넘어가라는 뜻이다
			//continue는 참이면 통과 break는 멈춤
			// continue aa;에서 aa는 라벨링이다 라벨표시한것만 수행하게되는것이다
			
			
			System.out.print(i);
		}
		System.out.println();
		}
	}
}

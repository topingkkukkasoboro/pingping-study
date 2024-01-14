package ex06;

import java.util.*;

//성적을 입력받아서 90점 이상이면 A, 80점 이상이면 B, 70점 이상이면 C, 그 외에는 D

public class Ex03 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int score = sc.nextInt();
		
		
		if(90 <= score) {
			System.out.println("A");
		}
		else if(80 <= score) { // else if 와 if의 차이는 존재한다 // else if를 사용했을때 값이 참이면 멈춘다
			System.out.println("B");
		}
		else if(70 <= score) { //(70 <= score && score < 80) 이런시으로 두번일 안해도 되니 써라
			System.out.println("C");
		}
		else { // 위의 if문에서 적용이 안된다면 나머지를 이쪽으로 보낸다 // 깔끔하이 편하다
			System.out.println("D");
		}
		
	}

}

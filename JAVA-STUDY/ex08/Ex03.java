package ex08;

import java.util.Scanner;

public class Ex03 {
	public static void main(String[] args) {

		String todolist[] = new String[100]; // todolist에 99까지부여 // 왜? 0부터 시작이니까

		while (true) { // 참일동안 뭐가 참일지 없으니 무한 반복
			Scanner sc = new Scanner(System.in); // 스캐너 생성
			int select = sc.nextInt(); // selcect에 스캐너로 int형 정수 입력

			if (select == 1) {
				System.out.println("할일 추가 만들어야함");
				todolist[0] = "공부";
			} else if (select == 2) {
				System.out.println("할일 삭제 만들어야함");
				todolist[1] = "";
			} else if (select == 3) {
				System.out.println("우선순위부여 만들어야함");
			} else {
				break; // while구문을 탈출하는 것이다 그래서, 1,2,3외의 수를 입력하면 탈출함
			}
		}
		System.out.println(todolist[0]);
	}
}

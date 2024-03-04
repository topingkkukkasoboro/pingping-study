package mariadb;

import java.util.Scanner;

public class design {
    public static void main(String[] args) {
        String[] menu = {"밥", "잠", "쉬기", "청소", "요리"};
        int currentIndex = 0;

        while (true) {
            // 화면 지우기 (콘솔 창을 깨끗하게 만들기 위한 용도)
            System.out.print("\033[H\033[2J");
            System.out.flush();

            // 메뉴 출력
            for (int i = 0; i < menu.length; i++) {
                if (i == currentIndex) {
                    System.out.print("> ");
                } else {
                    System.out.print("  ");
                }
                System.out.println((i + 1) + ". " + menu[i]);
            }

            // 방향키 입력 받기
            Scanner scanner = new Scanner(System.in);
            char input = scanner.next().charAt(0);

            // 입력이 엔터키가 아닌 경우 방향키로 메뉴 이동 처리
            switch (input) {
                case 'W':
                case 'w':
                    currentIndex = (currentIndex - 1 + menu.length) % menu.length;
                    break;
                case 'S':
                case 's':
                    currentIndex = (currentIndex + 1) % menu.length;
                    break;
                default:
                    System.out.println("다른 키를 입력했습니다. 방향키(W 또는 S)를 사용하세요.");
                    break;
            }
        }
    }
}

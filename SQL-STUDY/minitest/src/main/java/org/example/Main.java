package org.example;


import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while (true) {
            System.out.println("");
            System.out.println("메뉴를 선택하세요");
            System.out.println("");
            System.out.println("1. 등록하기");
            System.out.println("2. 검색하기");
            System.out.println("3. 종료하기");

            int choice = sc.nextInt();

            switch (choice) {
                case 1:
                    registerMember(sc);
                    break;
                case 2:
                    searchMember(sc);
                    break;
                case 3:
                    System.out.println("프로그램을 종료합니다.");
                    return;
                default:
                    System.out.println("1번, 2번, 3번 중에 선택해주세요.");
            }
        }
    }

    private static void registerMember(Scanner sc) {
        System.out.println("이름을 입력해주세요");
        String name = sc.next();
        System.out.println("나이를 입력해주세요");
        String age = sc.next();
        System.out.println("성별을 입력해주세요(남성 혹은 여성)");
        String gender = sc.next();
        System.out.println("휴대폰번호를 입력해주세요");
        String phoneNumber = sc.next();
        System.out.println("MBTI를 입력해주세요");
        String MBTI = sc.next();
        System.out.println("주소를 입력해주세요");
        String address = sc.next();
        System.out.println("별명을 입력해주세요");
        String nickName = sc.next();
        System.out.println("카테고리를 입력해주세요");
        String category = sc.next();

        DB db = new DB();

        Member member = new Member(name, age, gender, phoneNumber, MBTI, address, nickName, category);

        db.insert(member);

        System.out.println("계속 입력하시겠습니까? (1: 예, 2: 아니오)");
        int continueInput = sc.nextInt();
        if (continueInput != 1) {
            System.out.println("프로그램을 종료합니다.");
            System.exit(0);
        }
    }

    private static void searchMember(Scanner sc) {
        System.out.println("검색할 이름을 입력하세요: ");
        String searchName = sc.next();

        DB db = new DB();
        db.search(searchName);
    }
}

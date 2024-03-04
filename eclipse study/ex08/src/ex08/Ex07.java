package ex08;

import java.util.Scanner;

public class Ex07 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int total = 0;
        int productCnt = 0;
        int calcu_total = 0;

        total = sc.nextInt();
        productCnt = sc.nextInt();
        sc.nextLine(); // 엔터 문자 소비

        int[] itemPrice = new int[productCnt];
        int[] itemCnt = new int[productCnt];

        for (int i = 0; i < productCnt; i++) {
            String temp = sc.nextLine();
            String[] splitValues = temp.split(" ");
            if (splitValues.length == 2) {
                itemPrice[i] = Integer.parseInt(splitValues[0].trim());
                itemCnt[i] = Integer.parseInt(splitValues[1].trim());
            } else {
                System.out.println("잘못된 입력 형식입니다.");
                return; // 프로그램 종료
            }
        }

        for (int i = 0; i < productCnt; i++)
            calcu_total = calcu_total + itemPrice[i] * itemCnt[i];

        if (total == calcu_total) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}

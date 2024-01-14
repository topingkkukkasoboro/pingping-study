package org.example;

import java.util.Scanner;

public class Ex02 {
    //1.변수 2.연산자 3.제어문 4.배열
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

//        boolean aa = true;
//        while (aa);

        String answer = "";

        System.out.println("문자열입력");
        String str = sc.next();

        System.out.println("숫자입력");
        int n = sc.nextInt();

        System.out.println(str);
        System.out.println(n);

        // i = 0,1,2,3,4일때 동작하게 된다 5번반복 // 숫자 세는건 0부터
        for (int i = 0; i <5 ; i++) {
            answer = answer + str;

        }
        System.out.println(answer);
    }
}

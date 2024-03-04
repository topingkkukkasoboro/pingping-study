package org.example;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("이메일을 입력하세요");
        String email = scan.next();
        System.out.println("이름을 입력하세요");
        String name = scan.next();
        System.out.println("주소를 입력하세요");
        String addr = scan.next();
        System.out.println("패스워드를 입력하세요");
        String password = scan.next();
        MemberDB md = new MemberDB();

        Member member = new Member(email,name,addr,password);

        md.insert(member);
    }
}
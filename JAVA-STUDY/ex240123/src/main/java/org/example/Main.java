package org.example;

//alt + <- 왼쪽화면
//esc 소스로
//ctrl + tab 소스창 이동
// shift 두번 누르면 파일명 검색

import myclass.Member;

import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {
        System.out.println("Hello world!");

        List<Member> list = new ArrayList<>();

        Member member1 = new Member("홍길동",20);
        System.out.println(member1);

        Member member2 = new Member("고길동",30);
        System.out.println(member2);

        list.add(member1);
        list.add(member2);

        System.out.println(list);


    }
}
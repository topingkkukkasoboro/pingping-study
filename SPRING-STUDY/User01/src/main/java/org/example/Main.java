package org.example;

import org.example.conf.MyConf;
import org.example.member.MemberDto;
import org.example.member.MemberService;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Main {
    private static AnnotationConfigApplicationContext acac = null;
    public static void main(String[] args) {
        //insert user등록
        //list user 조회
        acac = new AnnotationConfigApplicationContext(MyConf.class);
        processNewCommand();
        ProCessListCommand();
        }

    private static void ProCessListCommand() {
        MemberService ms = acac.getBean(MemberService.class);
        ms.list();
    }

    private static void processNewCommand() {

        MemberService ms = acac.getBean(MemberService.class);

        MemberDto md = MemberDto.builder()
                .email("aaa@naver.com")
                .name("홍길동")
                .password("1234")
                .confirmPassword("1234").build();

        if (md.isEqualspassword()){
            System.out.println("비밀번호가 틀립니다");
            return;
        }
        ms.regist(md);
    }
}

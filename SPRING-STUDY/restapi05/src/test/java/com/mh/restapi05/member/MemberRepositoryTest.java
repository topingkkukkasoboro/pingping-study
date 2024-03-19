package com.mh.restapi05.member;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

//tdd 소스는 얼마나 구현했냐
//10%정도 했다
// 많이 만들어라
@SpringBootTest
class MemberRepositoryTest {
    @Autowired
    private MemberRepository memberRepository;

    @BeforeEach
    public void init(){
        System.out.println("delete all");
        memberRepository.deleteAll();
    }

    @Test
    public void savetest(){
        System.out.println("실행되나");
        Member member = Member.builder()
                .username("user")
                .password("1234")
                .email("aaa@naver.com").build();
        Member dbMember = memberRepository.save(member);

        // 맞는지 확인하는 작업
        assertEquals("aaa@naver.com",dbMember.getEmail());
        assertEquals("1234",dbMember.getPassword());
    }
    @Test
    public void selecttest(){
        System.out.println("실행되나2");
        List<Member> list = memberRepository.findAll();
        for(Member member :list){
            System.out.println(member);
        }
    }

}
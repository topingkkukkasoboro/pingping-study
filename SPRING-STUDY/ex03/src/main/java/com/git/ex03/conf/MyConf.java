package com.git.ex03.conf;

import com.git.ex03.member.MemberRepository;
import com.git.ex03.member.MemberService;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

// memberController
//membersercvice
//memberrepasitory
//member
//regist
//list
//http://localhost:8081//regist
//HashMap<email,member>
//http://localhost:8081//list
//HashMap 화면 출력
@Configuration
public class MyConf {
    @Bean
    public MemberService memberService(){
        return new MemberService();
    }
    @Bean
    public MemberRepository memberRepository(){
        return new MemberRepository();
    }
}

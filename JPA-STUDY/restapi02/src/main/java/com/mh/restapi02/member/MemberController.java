package com.mh.restapi02.member;

import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequiredArgsConstructor
public class MemberController {

    //select랑 insert
    private final MemberRepository memberRepository;


    //select 방법
    @GetMapping("member")
    public List<Member> allMember() {
        // findall을 하면 select구문을 실행한다
        List<Member> list = memberRepository.findAll();
        System.out.println(list);
        return list;
    }
    //insert 방법
    @PostMapping("member")
    public Member memberSave(String username, String email) {
        System.out.println(username);
        System.out.println(email);

        Member member = Member.builder()
                .username(username)
                .email(email)
                .build();

        Member dbMember = memberRepository.save(member);
        return dbMember;
    }
    // update 방법
    @PutMapping("member")
    public Member update(Long id, String username, String email){

        Member member = Member.builder()
                .id(id)
                .username(username)
                .email(email)
                .build();

        Member dbMember = memberRepository.save(member);
        return dbMember;

    }
    @DeleteMapping("member")
    public String delete(Long id){
        memberRepository.deleteById(id);
        return "delete id = " + id;

    }
}

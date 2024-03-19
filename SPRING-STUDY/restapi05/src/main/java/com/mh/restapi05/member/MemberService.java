package com.mh.restapi05.member;

import lombok.RequiredArgsConstructor;
import lombok.SneakyThrows;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;
// MemberService는 UserDetailsService 이다.
// 그럼으로 Spring Securit에서 자동으로 등록해서 사용된다
@Service
@RequiredArgsConstructor
public class MemberService implements UserDetailsService {
    private final MemberRepository memberRepository;
    
    // 중복체크하느것
    // 중복이면 에러로 빠짐
    @SneakyThrows
    public Member save(Member member){
        Optional<Member> optionalMember =
                memberRepository.findByEmail(member.getEmail());
        if (optionalMember.isPresent()){
            throw new IllegalAccessException("이미 존재하는 회원 이메일");
        }
        return memberRepository.save(member);
    }
    public List<Member> getllUser(){
        return memberRepository.findAll();
    }
    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        System.out.println("일로오나");
        return null;
    }
}

package com.mh.restapi05.member;

import jakarta.validation.Valid;
import lombok.Getter;
import lombok.RequiredArgsConstructor;
import org.modelmapper.ModelMapper;
import org.springframework.beans.BeanUtils;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDateTime;

@RestController
@RequestMapping("/member")
@RequiredArgsConstructor
public class MemberController {

    private final MemberService memberService;
    @GetMapping("")
    public String member(){
        return "member";
    }
    @PostMapping("")
    public String member(@Valid @RequestBody MemberDto memberDto){
        ModelMapper modelMapper = new ModelMapper();
        Member member = modelMapper.map(memberDto,Member.class);
        member.setWriteDate(LocalDateTime.now());
        memberService.save(member);
        System.out.println("member : " + member);
        return "member";
    }

}

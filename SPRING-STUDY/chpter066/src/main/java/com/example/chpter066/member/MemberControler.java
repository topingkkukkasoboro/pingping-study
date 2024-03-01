package com.example.chpter066.member;

import org.springframework.ui.Model;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.Arrays;
import java.util.List;

@Controller
@RequestMapping("member")
public class MemberControler {

    @GetMapping("list")
    public String list(Model model){

        List<Member> list = Arrays.asList(
        Member.builder().name("홍길동").age(30).build(),
        Member.builder().name("고길동").age(40).build());

        System.out.println(list);
        model.addAttribute("list",list);

        String hello = "안녕하세요";
        model.addAttribute("Hello",hello);
        return "list";
    }
}

package org.example;

import org.example.component.MemberService;
import org.example.conf.Myconfig;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {

        AnnotationConfigApplicationContext context
                =new AnnotationConfigApplicationContext(Myconfig.class);

        MemberService memberService = context.getBean(MemberService.class);
        memberService.regist();

/*        String[]str = context.getBeanDefinitionNames();
        Arrays.stream(str).forEach(System.out::println);*/

        context.close();
        }
    }

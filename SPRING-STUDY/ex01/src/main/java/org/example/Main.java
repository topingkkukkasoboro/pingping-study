package org.example;

import org.example.component.AA;
import org.example.component.BB;
import org.example.conf.Appcontext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Main {
    public static void main(String[] args) {

        AnnotationConfigApplicationContext context =
                new AnnotationConfigApplicationContext(Appcontext.class);

        BB bb = context.getBean(BB.class);
        System.out.println(bb.getHi());

        AA a1 = context.getBean(AA.class);
        System.out.println(a1);

        AA a2 = context.getBean(AA.class);
        System.out.println(a2);

        a1.setName("내이름"); // 같은 객채를공유중

        System.out.println(a1.getName());
        System.out.println(a2.getName());
        System.out.println(a1==a2);

        context.close();
    }
}
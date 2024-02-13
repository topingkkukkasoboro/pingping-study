package org.example;

import java.util.Arrays;
import java.util.List;
import java.util.function.BiConsumer;
import java.util.function.Consumer;

public class Main7 {
    public static void main(String[] args) {
        List<Integer>list = Arrays.asList(11,22,33,44,55);
        list.forEach(integer -> System.out.println(integer));

        System.out.println();
        for(int i : list){
            System.out.println(i);
        }
        
        System.out.println();
        //consumer는 반환이 없기에 그 안에서 끝난다
        Consumer<String >consumer = s -> System.out.println(s.length());
        consumer.accept("asdasd");
        consumer.accept("1456");


        BiConsumer<String,String> biConsumer = (s, s2) -> System.out.println(s+s2);
        biConsumer.accept("공부 어려워","해라");
        biConsumer.accept("어렵다","나약하다");

        Consumer<Integer> con = new Consumer<Integer>() {
            @Override
            public void accept(Integer integer) {

            }
        };

        Consumer<Integer> con1 = (i) -> System.out.println(con);
    }
}

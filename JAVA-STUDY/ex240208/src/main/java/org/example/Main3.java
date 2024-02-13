package org.example;

import java.util.Arrays;
import java.util.List;
import java.util.Random;

@FunctionalInterface // 매서드가 딱 하나만 존재 하는 인터페이스
interface AA{
    int gen();
}

public class Main3 {

    public static void main(String[] args) {
        AA aa = () -> {
            return new Random().nextInt(50);
        };
        System.out.println(aa.gen());

        List<Integer> list = Arrays.asList(aa.gen(), aa.gen(), aa.gen());
        System.out.println(list);
    }
}

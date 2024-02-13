package org.example;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.function.Supplier;

public class Main5 {

    public static void main(String[] args) {

        Supplier<Integer> s = () -> {
            return new Random().nextInt(50);
        };

        System.out.println(s.get());

        List<Integer>list = dolist(s,5);
        System.out.println(list);

    }

    private static List<Integer> dolist(Supplier<Integer> s, int n) {
            List<Integer>list = new ArrayList<>();
            for (int i = 0; i <n; i++) {
                list.add(s.get());
            }
            return list;
        }
    }



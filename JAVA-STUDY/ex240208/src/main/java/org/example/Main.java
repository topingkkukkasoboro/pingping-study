package org.example;

import java.util.*;
import java.util.function.Consumer;

public class Main {
    public static void main(String[] args) {

        List<String> list = Arrays.asList("ROBOT", "APPLE", "BANANA", "BOX", "AA");
        list = new ArrayList<>(list);

        //Arrays.sort 배열정렬
//        Collections.sort(list, new Comparator<String>() {
//            @Override
//            public int compare(String o1, String o2) {
//                return o1.length() - o2.length();
//            }
//        });
        // 컬렉션 정렬
        Comparator<String > comp = (o1, o2) -> o1.length() - o2.length();
        Collections.sort(list,comp);

        Collections.sort(list, (o1, o2) -> o1.length() - o2.length());
        System.out.println(list);

        Collections.sort(list, new Comparator<String>() {
            @Override
            public int compare(String o1, String o2) {
                return o1.length() - o2.length();
            }
        });

        // for문 출력
        for (int i = 0; i < list.size(); i++)
            System.out.println(list.get(i));
            System.out.println();

            Consumer<String> con = (s) -> System.out.println(s);
            list.stream().forEach(con);

        //stream 스트림
        list.stream().forEach(s -> System.out.println(s));
        list.stream().forEach(con);

    }
}
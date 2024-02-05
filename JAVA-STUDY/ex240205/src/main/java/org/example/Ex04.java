package org.example;

import java.sql.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Ex04 {

    public static void main(String[] args) {
        List<String> list = Arrays.asList("Box","Robot","Apple");
        list = new ArrayList<>(list);

        List<String> copyList = new ArrayList<>(list);
        Collections.copy(copyList,list);
//        System.out.println(copyList);
        System.out.println("=======================");
        System.out.println(copyList);
        System.out.println("=======================");

        List<String> tlist = list.stream().filter(
                s -> s.length() == 5
        ).toList();

        copyList.set(0,"aaa");
        System.out.println(list);
        System.out.println(copyList);
        System.out.println(tlist);

        Collections.sort(list);
        System.out.println(list);

        int idx = Collections.binarySearch(list,"Robot");
        System.out.println(idx);

        System.out.println(list.get(idx));
    }
}

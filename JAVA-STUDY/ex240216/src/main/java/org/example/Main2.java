package org.example;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Main2 {
    public static void main(String[] args) {
        List<String> list1 = Arrays.asList("BOX","TOY","ROBOT","SAMPLE");
        list1 = new ArrayList<>(list1);
        List<String >clist = Arrays.asList("BOX","TOY","ROBOT","SAMPLE");
        clist = new ArrayList<>(clist);

        list1.addAll(clist);
        System.out.println(list1);
        System.out.println();
        List<String> list2 = new ArrayList<>();
        for(String temp :list1){
            if (temp.length() > 3)
                list2.add(temp);
        }
            System.out.println(list2);

            List streamlist =
            list1.stream().filter(str -> str.length() > 3)
                            .collect(ArrayList::new,(lst,str) ->lst.add(str),
                                    (lst1,lst2) -> lst1.addAll(list2));
        System.out.println(streamlist);

        System.out.println();

        List streamlist2 = list1.stream().filter(s -> s.length()>3).collect(Collectors.toList());
        System.out.println(streamlist2);


    }
}

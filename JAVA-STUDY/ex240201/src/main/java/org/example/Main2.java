package org.example;

import java.sql.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

//불변객체이기때문에 넣을 수 없음
//list.add("eee")

public class Main2 {
    public static void main(String[] args) {

        List<String> list = Arrays.asList("aaa", "bbb", "ccc");
        System.out.println(list);

        List<String> mylist = new ArrayList<>(list);
        mylist.add("eee");

       mylist.addAll(Arrays.asList("fff","ggg","hhh"));

        System.out.println(mylist);

        List<String> list3 = new LinkedList<>(list);
        System.out.println(list3);

        List<Integer>list2 = Arrays.asList(111,222,333);
        System.out.println(list2);
    }


}

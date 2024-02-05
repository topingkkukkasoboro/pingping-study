package org.example;

import java.util.*;

public class Main {
    public static void main(String[] args) {

        Set<String> set = new HashSet<>();

        List<String> list = new LinkedList<>();
        list.add("test");
        String item = list.get(0);

        System.out.println(new String("BOX").hashCode());
        System.out.println(new String("BOX").hashCode());
        System.out.println();

        set.add("BOX"); // BOX가 두개라서 하나로만 나옴
        set.add("ROBOT");
        set.add("BOX"); // 동일 인스턴스는 중복되어 나오지 않는다
        set.add("TOY");

        System.out.println(set);

        Iterator<String> itr = set.iterator();
        while (itr.hasNext()){
            String temp = itr.next();
            System.out.println(temp);
        }
        System.out.println();
        for (String temp : set){
            System.out.println(temp);
        }
        }
    }

package org.example;

import java.util.Collections;
import java.util.List;
import java.util.ArrayList;

//정렬의 예시
//Arrays.sort();
//Collections.sort();
//comaparable 인터페이스를 상속 받아서.. compareTo매소드를 재정의 해야한다.
public class Main {
    public static void main(String[] args) {

        ItmeDB id = new ItmeDB();
        List<Item> list = id.findAll();

        for (int i = 0; i < list.size() ; i++) {
            Item temp = list.get(i);
            System.out.println(temp);
        }

        Collections.sort(list);

        System.out.println(list);

        }
    }

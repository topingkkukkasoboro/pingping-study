package org.example;

//문자열을 정렬할 수 있는 List를 만들어 보자

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;


public class Ex01 {

    public static void main(String[] args) {

        List<String>list = Arrays.asList("Box","Toy","Robot","Weapon");
        list = new ArrayList<>(list);

        //Arrays.sort();는 불가능 // 배열이 아니라 자료형 타입이라서
        Collections.sort(list);
        System.out.println(list);
    }

}

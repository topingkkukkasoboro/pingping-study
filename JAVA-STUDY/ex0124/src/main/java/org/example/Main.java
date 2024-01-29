package org.example;

import lombok.AllArgsConstructor;
import lombok.ToString;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        //자식객체는 부모객체를 담을수 있다
        //부모객체는 자식객체를 참조할수 있다.
//         Friend[] f = new Friend[5];
//
//        f[0] = new UniFriend("DogRoadBronze","computer","010111111");
//        f[1] = new ComFriend("GoRoadBronze","slave","0102222222");
//
//        System.out.println(f[0]);
//        System.out.println(f[1]);

        List<Friend> list = new ArrayList<>();
        list.add(new UniFriend("DogRoadBronze","computer","010111111"));
        list.add(new ComFriend("GoRoadBronze","slave","0102222222"));

        System.out.println(list);
        }
    }

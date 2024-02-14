package org.example;

import java.util.Optional;

public class Main9 {

    public static void main(String[] args) {

        Optional<ContInfo> ci = Optional.of(new ContInfo(null,"Republic of korea"));

        String phone = ci.map(s -> s.getPhone()).orElse("번호없음");
        String addr = ci.map(s -> s.getAddr()).orElse("집 없음");

        System.out.println(addr);
        System.out.println(phone);
    }
}

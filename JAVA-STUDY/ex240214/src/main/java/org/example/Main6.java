package org.example;

import java.util.Optional;

public class Main6 {

    public static void main(String[] args) {


        Optional<String> os1 = Optional.of("TOY");
        Optional<String> os2 = Optional.ofNullable(null);
        Optional<String> os3 = Optional.empty();

        os1.ifPresent(s -> System.out.println(os1));
        os2.ifPresent(s -> System.out.println(os2));
        os3.ifPresent(s -> System.out.println(os3));

        if (os1.isPresent())
            System.out.println(os1);

        if (os2.isPresent())
            System.out.println(os2);

        if (os3.isEmpty())
            System.out.println("os3");
    }
}

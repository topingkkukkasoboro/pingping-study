package org.example;

import java.util.Locale;
import java.util.Optional;

public class Main7 {

    public static void main(String[] args) {

        Optional<String> os1 = Optional.of("Optinal String");
        Optional<String> os2 = os1.map(s -> s.toUpperCase());

        System.out.println(os1.get());
        System.out.println(os2.get());

        System.out.println(os1);
        System.out.println(os2);

        Optional<String> os3 = os1.map(s -> s.replace("","")).map(s -> s.toLowerCase());

        System.out.println(os3);
    }

}

package org.example;

import java.util.stream.IntStream;
import java.util.stream.Stream;

public class Main10 {
    public static void main(String[] args) {
        System.out.println(IntStream.of(1,3,5,7,9).sum());
        System.out.println(Stream.of(1,3,5,7,9).count());
        IntStream.of(1,3,5,7,9).average().ifPresent(System.out::println);
        IntStream.of(1,3,5,7,9).min().ifPresent(System.out::println);

        double avg = IntStream.of(1,3,5,7,9).average().orElse(0);
        System.out.println(avg);

        // for문을 사용하면 이렇게 되는거라구 !_!
        int[] arr = {1,3,5,7,9};
        double sum = 0;
        for(int i : arr) {
            sum += i;
        }
        System.out.println(sum/arr.length);

    }
}

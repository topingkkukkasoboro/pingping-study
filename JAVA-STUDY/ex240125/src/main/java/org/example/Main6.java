package org.example;

import java.util.InputMismatchException;

public class Main6 {

    public static void main(String[] args) {

        System.out.println("시작");
        try {
            throw new InputMismatchException();
        } catch (InputMismatchException e) {
          e.printStackTrace();
        }
        System.out.println("끝");
    }
}

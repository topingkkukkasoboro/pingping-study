package org.example;

public class Main3 {
    public static void main(String[] args) {
        Print prn = new Print();
        prn.Print();

        Printable printable = new Printable() {
            @Override
            public void Print() {
                System.out.println("인터페이스");

            }
        };
        printable.Print();

        Printable lamda1 = ()->{
            System.out.println("람다");
        };
        lamda1.Print();
    }
}

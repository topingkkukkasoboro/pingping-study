package org.example;

class Cake {
    public void yummy() {
        System.out.println("Cake yummy");
    }
}

class Acake extends Cake {
    public void yummy() {
        System.out.println("ACake yummy");
    }
}
class Bcake extends Acake {
    public void yummy() {
        super.yummy();
        System.out.println("BCake yummy");
    }
}

public class Main4 {

    public static void main(String[] args) {
        Cake cb = new Bcake();
        Cake ca = new Acake();
        cb.yummy();
        ca.yummy();


        //instanceof 담을 수 있는지 확인하는 것
        System.out.println("=================");
        System.out.println(cb instanceof Bcake); // cb를 Bcake에 담을 수 있냐? true
        System.out.println(cb instanceof Acake); // cb를 Acake에 담을 수 있냐? true
        System.out.println("=================");

        System.out.println("=================");
        System.out.println(ca instanceof Bcake); // ca를 Bcake에 답을 수 있냐? false
        System.out.println(ca instanceof Acake); // ca를 Ackae에 담을 수 있냐? true
        System.out.println("=================");
    }
    }


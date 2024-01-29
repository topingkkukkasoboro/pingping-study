package org.example;

public class AA {

    private int a = 10;
    // 인텔리제이에서는 alt + insert 누르고 gett and setter
    public int getA() {
        return a;
    }

    public void setA(int a) {
        this.a = a;
    }

    public void doA(){
        System.out.println("AA.doA"+a);
    }

    public static void doB(){
        System.out.println("AA.doB");

    }

}

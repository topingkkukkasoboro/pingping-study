package org.example;
//스태틱 매서드에서는 스태틱 변수 사용가능, heap 영역 변수 사용x
//heap 매서드이면 hep영역 변수, 스태틱 변수 사용 가능
class Outer{
private static int num = 0;
public static class Nested1 {
    public void add(int n) {
       Outer.num += n;
    }
}
public static class Nested2 {
    public int get() {
        int a = 10;
        return num +a;
    }
    public void doPrint(){
        System.out.println(num);
    }
}
}
public class Main {
    public static void main(String[] args) {
    Outer.Nested1 ns1 = new Outer.Nested1();
    Outer.Nested2 ns2 = new Outer.Nested2();

    ns1.add(100);
        System.out.println(ns2.get());
        ns2.doPrint();
    }
}

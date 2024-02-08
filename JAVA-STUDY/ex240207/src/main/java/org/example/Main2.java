package org.example;

class Outer2{
private int num = 0;
class member {
    void add(int n) {
        num += n;
    }
}
int get() {
    return num;
}
        }
public class Main2 {
    public static void main(String[] args) {

        Outer2 o1 = new Outer2();
        Outer2 o2 = new Outer2();

        Outer2.member o1m =o1.new member();
        Outer2.member o2m =o2.new member();

        o1m.add(50);
        o2m.add(100);
        System.out.println(o1m);
        System.out.println(o2m);

    }
}

package org.example;

public class Main6 {

//    private static <T>Box<T>makeBox(T o){
//        return new Box<T>();
//    }
private static <T>Box<T>makeBox(T o){
    return new Box<T>();
}


    public static void main(String[] args) {
        Box<String> sbox = makeBox("sweet");
        System.out.println(sbox);

        Box<Integer> ibox = makeBox(100);
        System.out.println(ibox);

        System.out.println(makeBox(100));
    }
}

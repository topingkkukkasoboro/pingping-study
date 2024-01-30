package org.example;

public class Main2 {

    public static void main(String[] args) {

        Box<String> box1 = new SteelBox<String>();
//        Box<String> box2 = new SteelBox<Integer>();

        Box<Integer> box2 = EmptyBoxFactory.makeBox();
        Box<String> box3 = EmptyBoxFactory.makeBox();

        //Box<Integer> box4 = EmptyBoxFactory.peekBox(box2);
        EmptyBoxFactory.peekBox(box3,"오버로딩");

        // 왜 오류가 나있는거에요!! >:-ㅁ !!!
        // 당장 고쳐어어어어어어ㅓㅓㅓㅓㅓㅓㅓㅓ

        // 당신은 천재야

        // 유아 지니어스 베리 굿 당장 집으로 가.

        // 메인은 왼쪽에 있어야지!!!!


    }
}

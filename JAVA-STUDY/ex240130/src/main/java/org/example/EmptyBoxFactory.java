package org.example;

public class EmptyBoxFactory {

    public static <T> Box <T> makeBox(){
        Box<T> box = new Box<T>();
        return box;
    }

    public static void inbox(Box <? extends Toy> box, Toy n ){ // get만 가능
        Toy toy = box.getObj();
        System.out.println(box);
    }

    public static void outbox(Box <? super Toy> box, Toy n ){ // set만 가능
        //Toy toy = box.getObj();
        //System.out.println(box);
        box.setObj(new Toy());
    }

   public static void peekBox (Box<?>box, String a){
//        System.out.println(box);
//        // 이건 오른쪽에 있어야지!!!
//        //(ㅇㅅㅇ);;
    }
}

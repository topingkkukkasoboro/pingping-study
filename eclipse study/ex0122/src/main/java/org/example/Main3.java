package org.example;

class superCls{
    static int count = 0;
}

class subCls extends superCls{
    public void setCount(){
        superCls.count = 100;
    }
}

public class Main3 {

    public static void main(String[] args) {

        //변수든 메서드든 메모리사에올려 놓고 써야한다.
        System.out.println(superCls.count);
        System.out.println(subCls.count);

        superCls.count = 200;

        System.out.println(superCls.count);
        System.out.println(subCls.count);

        subCls sc = new subCls(); // static 함수가 아니라서 객체생성
        sc.setCount();
       // subCls.setCount();
        System.out.println(superCls.count);
        System.out.println(subCls.count);
    }
}

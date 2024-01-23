package org.example;

class Supercls{

    public int a =10;
    public void doA(){
        System.out.println("SuperCls doA");
    }
}

class SubCls extends Supercls{
    //오버로딩 매게변수가 다른 함수명이 동일해도 된다
    //덮어 쓰기 개념
    // extends는 상속 받는다
    public int b = 20;
    public void doA(){
        System.out.println("SubCls doA");
    }
}

public class Main2 {
    public static void main(String[] args) {
    Supercls sc = new Supercls();
    sc.doA();

    SubCls subCls = new SubCls();
    subCls.doA();
    }
}

package org.example;

//import java.Lang*;
// 기본 생성자 생략 가능-> 다른생성자 선언하면 기본생성자 생략 불가
// super(); -> 생략 가능
//toString(); -> 생략가능

// 클래스부분을 {}에 맞춰 드래그하고 f5번을 누르면 새롭게 클래스르 만들어서 뺄수 있음
// 대신에 원래 클래스에 있던 내용을 삭제해야함

class MobliePhone {
    protected String number;
    // 다른 생성자 선언시 기본생성자 생략 불가
    //public MobliePhone(){}
    public MobliePhone(String number) {
        this.number = number;
    }
    public void answer(){
        System.out.println("대답했다 번호는"+number);
    }
}


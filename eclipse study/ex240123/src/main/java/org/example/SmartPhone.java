package org.example;

//import java.Lang*;
// 기본 생성자 생략 가능-> 다른생성자 선언하면 기본생성자 생략 불가
// super(); -> 생략 가능
//toString(); -> 생략가능

class SmartPhone extends MobliePhone{ // 상속 받았기 때문에 사용가능
    private String androdiver;
    public SmartPhone(String number, String ver) {
        super(number);
        this.androdiver = ver;
    }
    public  void  PlayApp(){
        System.out.println("앱 실행함 안드로이드 버전은 = " + androdiver);
    }
}


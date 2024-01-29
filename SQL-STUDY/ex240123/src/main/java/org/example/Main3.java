package org.example;

//import java.Lang*;
// 기본 생성자 생략 가능-> 다른생성자 선언하면 기본생성자 생략 불가
// super(); -> 생략 가능
//toString(); -> 생략가능

public class Main3 {
    //스마트폰은 모바일폰이다 is a  관계

    public static void main(String[] args) {
        SmartPhone sp = new SmartPhone("010-3203-7533", "1.8");
        sp.PlayApp();
        sp.answer();

        // 부모 객체         // 자식 객체
        //자식객체는 부모객체에 담을수있다
        //부모객체는 자식객체를 참조할수있다
        //다형성이라고한다
        MobliePhone mp = new SmartPhone("010-3203-7533","2.0");
        mp.answer();
    }
}

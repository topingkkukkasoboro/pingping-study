package org.example;

interface Upper{
    default public String doUpper(String con){return con.toUpperCase();} // 대문자 반환
}

interface Lower{
    default public String doLower(String con){return con.toLowerCase();} // 소문자 반환
}

interface Printa{
    void doA(String con);
}
class MyPrinnter implements Printa, Upper{

    @Override
    public void doA(String con) {
        System.out.println(doUpper(con));
    }
}
public class Main3 {
    public static void main(String[] args) {

        MyPrinnter mp = new MyPrinnter();
        mp.doA("acdefg");

        System.out.println(mp instanceof Upper);
        // 다양성
        // 자식객체를 부모객체에 담을수 있다
        //부모객체는 자식객체를 참조 할 수 있다

        if (mp instanceof Upper){
            Upper up = mp;
        }

        try{
            Lower lower = (Lower) mp;
            System.out.println("여기는 실행안됨");
        }catch (ClassCastException cce){
            System.out.println("형변환예외");
        }
        System.out.println(mp instanceof Lower);
    }
}

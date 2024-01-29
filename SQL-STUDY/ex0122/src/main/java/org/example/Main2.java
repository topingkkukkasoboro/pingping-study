package org.example;

class A1{
    private String name;

    // alt + insert + constructor 생성자 만들기

    public void setName(String name) {
        this.name = name;
    }
    public A1(){

    }
    public A1(String name) { // A1의 생성자 만듬
        this.name = name;
    }

    @Override
    public String toString() {
        return "A1{" +
                "name='" + name + '\'' +
                '}';
    }
}

public class Main2 {
    //생성자로 클래스변수중 private를 값을 바꿀 수 있다
    // class 변수에 해당되는 private는 setter 로 값을 바꿀 수 있다

    public static void main(String[] args) {

        A1 a1 = new A1("A1");
        System.out.println(a1);

        A1  a11 = new A1();
        a1.setName("a11");
        System.out.println(a11);
    }
}

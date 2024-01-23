package org.example;

class Man {
    private String name;
    Man(){
        System.out.println("Man 부모생성자");
    }
    Man(String name){
        this.name = name;
    }

    public void yourname() {
        System.out.println("name = " + name);
    }
}

class businessMan extends Man {
    private String company;
    public String position;


    //기본 생성자 생략가능
    businessMan() {
        //super();
        System.out.println("기본생성자");
    }
    businessMan(String conmany, String positon, String name){

        super(name);
        System.out.println("다른 생성자");
        this.company = conmany;
        this.position = positon;
    }

    public void yourInfo() {
        System.out.println("company = " + company);
        System.out.println("positon = " + position);
        yourname();
    }

}


public class Main1 {
    // setter
    // 생성자 초기화 방식
    public static void main(String[] args) {
        businessMan bm1 = new businessMan("그린컴퓨터학원", "학생", "강보성");
        bm1.yourInfo();

    }
}

package org.example;

enum Person {
    MAN(10, "김길동"), WOMAN(20, "고길동");

    private int age;
    private String name;

    Person(int age, String name) {
        this.age = age;
        this.name = name;
        System.out.println("생성자 호출");
    }

    @Override
    public String toString() {
        return "Person age " + age + "Person name" + name;
    }
}

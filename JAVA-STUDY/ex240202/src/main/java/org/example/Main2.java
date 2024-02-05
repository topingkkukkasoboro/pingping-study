package org.example;


import java.util.HashSet;
import java.util.Objects;
import java.util.Set;

class car{
private String color;
private String model;

    public car(String color, String model) {
        this.color = color;
        this.model = model;
    }

    @Override
    public String toString() {
        return "car{" +
                "color='" + color + '\'' +
                ", model='" + model + '\'' +
                '}';
    }


    @Override
    public int hashCode() {
        return Objects.hash(color, model);
    }

    public boolean equals(Object obj){
        return this.color.equals(((car)obj).color) && this.model.equals(((car)obj).model);
    }
}

public class Main2 {
    public static void main(String[] args) {
        Set<car> set = new HashSet<>();
        set.add(new car("빨강","k3"));
        set.add(new car("흰색","k3"));
        set.add(new car("빨강","k3"));

        System.out.println(set);
    }
}

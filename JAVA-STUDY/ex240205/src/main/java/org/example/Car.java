package org.example;

import java.util.Comparator;

//alt + 1 옆에 프로젝트 창으로 이동
// alt  + insert누르면 생성 가능
public class Car implements Comparable <Car> {
     private int disp;
    public Car(int disp) {
        this.disp = disp;
    }

    public int getDisp() {
        return disp;
    }

    @Override
    public String toString() {
        return "Car{" +
                "disp=" + disp +
                '}';
    }
    @Override
    public int compareTo(Car o) {
        return this.disp - o.disp;
    }
}

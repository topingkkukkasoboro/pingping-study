package org.example;

import java.util.Scanner;

class AA{
    public void doA(){}
}


public class Ex03 {
    public static void main(String[] args) {
        AA a = new AA();
        Scanner sc = new Scanner(System.in);
        Integer i = new Integer(10);
        //10진수를 2진수로 바꾸는함수 사용
        String binString = Integer.toBinaryString(i);
        System.out.println(binString);
    }
}

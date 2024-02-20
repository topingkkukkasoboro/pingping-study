package org.example;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;

public class Main7 {
    public static void main(String[] args) {
        try(BufferedWriter bw = new BufferedWriter(new FileWriter("ccc.txt"))){
        bw.write("공부를 하기 위해서 돈이 필요한건 아니다 ");
        bw.write("존나 많은 돈이 필요하다");
        bw.newLine();
        bw.write("그렇다");
        }catch (Exception e){
            e.printStackTrace();
        }try(BufferedReader br = new BufferedReader(new FileReader("ccc.txt"))){
        while (true){
            String txt = br.readLine();
            if(txt == null)
                break;
            System.out.println(txt);
        }
        }catch (Exception e){
            e.printStackTrace();
        }
    }
}

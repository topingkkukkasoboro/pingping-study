package org.example;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class Main7 {
    public static void main(String[] args) {
        //io와 nio를 섞어서 사용하는데 nio2다
        Path fp = Paths.get("nio2.dat");


        try (DataOutputStream dos = new DataOutputStream(Files.newOutputStream(fp))){
/*            try (DataOutputStream dos = new DataOutputStream(Files.newOutputStream("nio2.dat"))){*/
        dos.writeInt(10);
        dos.writeDouble(20.2);
        }catch (Exception e) {
            e.printStackTrace();
        }
        try (DataInputStream dos = new DataInputStream(Files.newInputStream(fp))){
/*            try (DataInputStream dos = new DataInputStream(Files.newInputStream("nio2.dat")){*/
            int temp = dos.readInt();
            System.out.println(temp);
            double temp1 = dos.readDouble();
            System.out.println(temp1);
        }catch (Exception e) {
            e.printStackTrace();
        }
        }
    }


package org.example;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

class SBOX {
    private String name;
    private int age;
    public SBOX(String name, int age) {
        this.name = name;
        this.age = age;
    }
    @Override
    public String toString() {
        return "SBOX{" +
                "name='" + name + '\'' +
                ", age=" + age +
                '}';
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }
}

public class Main8 {
    public static void main(String[] args) {
        SBOX sbox1 = new SBOX("감자", 20);
        SBOX sbox2 = new SBOX("감자", 20);
        try (ObjectOutputStream ocs = new ObjectOutputStream(new FileOutputStream("obj.bin"))) {
            ocs.writeObject(sbox1);
            ocs.writeObject(sbox2);
        } catch (Exception e) {
            e.printStackTrace();
        }
        try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream("obj.bin"))) {
            SBOX obj1 = (SBOX) ois.readObject();
            System.out.println(obj1);
            SBOX obj2 = (SBOX) ois.readObject();
            System.out.println(obj2);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}

package org.example;

import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class Main3 {
    public static void main(String[] args) {
        Path path = Paths.get("C:\\Users\\PC_DSKTOP2\\Desktop\\javastudy\\AA.java");
        Path dp = Paths.get("C:\\Users\\PC_DSKTOP2\\Desktop\\javastudy\\EMTY");

        Path aaa = Paths.get("C:\\aa\\bb\\cc");

        try {
            if(!Files.exists(path))
            Files.createFile(path);
            if (!Files.exists(dp))
            Files.createDirectory(dp);
            if (!Files.exists(aaa))
            Files.createDirectories(aaa);
        } catch (IOException e) {
            e.printStackTrace();
        }

        try(FileWriter fw = new FileWriter("aaa.txt")){
            fw.write("한솥"+"\n");
            fw.write("뭐"+"\n");
            fw.write("먹지");

        }catch (Exception e){
            e.printStackTrace();
        }

    }
}

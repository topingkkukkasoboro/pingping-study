package org.example;

import java.io.File;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.util.List;

import static java.nio.file.StandardOpenOption.APPEND;

public class mAIN5 {
    public static void main(String[] args) throws IOException {

        Path fp = Paths.get("nio.txt");
        if(!Files.exists(fp))
        Files.createFile(fp);

        Files.write(fp,"문자열 쓸거다".getBytes(StandardCharsets.UTF_8),StandardOpenOption.APPEND);
        Files.write(fp,"문자열 쓸거다".getBytes(StandardCharsets.UTF_8), StandardOpenOption.APPEND);
        Files.write(fp,"문자열 쓸거다".getBytes(StandardCharsets.UTF_8), StandardOpenOption.APPEND);

        List<String>list = Files.readAllLines(fp);
        System.out.println(fp);
    }
}

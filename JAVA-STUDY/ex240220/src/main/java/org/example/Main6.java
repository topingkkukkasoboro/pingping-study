package org.example;

import java.io.IOException;
import java.nio.file.*;


public class Main6 {
    public static void main(String[] args) throws IOException {

        Path org = Paths.get("nio.txt");

        //파일이 없다면 만들어라
        if(!Files.exists(org))
        Files.createFile(org);
        Path dat = Paths.get("niocopy.txt");

        //파일 복사해라 존재하면 대체
        Files.copy(org, dat, StandardCopyOption.REPLACE_EXISTING);

        //파일 이동해라 // 원래 파일은 삭제
        try {
            Files.move(Paths.get("aaa.txt"), Paths.get("bbb.txt"), StandardCopyOption.REPLACE_EXISTING);
        }catch (Exception e){
            e.printStackTrace();
        }


    }
}

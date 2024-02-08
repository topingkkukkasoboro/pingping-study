package org.example;

import java.util.Scanner;

public class Main1 {
    public static void main(String[] args) {

        //static이면
        // ENUM_SYUDY_DB.insert();


        ENUM_STUDY_DB enumStudyDb = new ENUM_STUDY_DB();

        while (true) {
            enumStudyDb.insert();
            enumStudyDb.select();

            Scanner scan = new Scanner(System.in);

            System.out.println("수정하고 싶은 id 입력");
            int temp = scan.nextInt();
            enumStudyDb.update(temp);

            System.out.println("삭제하고 싶은 id 입력");
            temp = scan.nextInt();
            enumStudyDb.delete(temp);

            enumStudyDb.select();
        }
        }
    }

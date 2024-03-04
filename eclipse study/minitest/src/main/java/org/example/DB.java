package org.example;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
public class DB {

    public void insert(Member member) {

        try {
            Connection con = DriverManager.getConnection(DBINFO.url, DBINFO.user, DBINFO.password);
            PreparedStatement pstmt = con.prepareStatement(
                    "insert into mini" +
                    "(name, age, gender, phoneNumber, MBTI, address, nickName, category)" +
                    " values (?, ?, ?, ?, ?, ?, ?, ?)");

            pstmt.setString(1, member.getName());
            pstmt.setString(2, member.getAge());
            pstmt.setString(3, member.getGender());
            pstmt.setString(4, member.getPhoneNumber());
            pstmt.setString(5, member.getMBTI());
            pstmt.setString(6, member.getAddress());
            pstmt.setString(7, member.getNickName());
            pstmt.setString(8, member.getCategory());
            pstmt.executeUpdate();


        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void search(String name) {
        try {
            Connection con = DriverManager.getConnection(DBINFO.url, DBINFO.user, DBINFO.password);
            PreparedStatement pstmt = con.prepareStatement(
                    "SELECT * FROM mini WHERE name LIKE ?");
            pstmt.setString(1, "%" + name + "%");

            ResultSet rs = pstmt.executeQuery();

            while (rs.next()) {
                System.out.println("");
                System.out.println("검색 결과");
                System.out.println("");
                System.out.println("이름 : " + rs.getString("name"));
                System.out.println("나이 : " + rs.getString("age"));
                System.out.println("성별 : " + rs.getString("gender"));
                System.out.println("휴대폰번호 : " + rs.getString("phoneNumber"));
                System.out.println("MBTI : " + rs.getString("MBTI"));
                System.out.println("주소 : " + rs.getString("address"));
                System.out.println("별명 : " + rs.getString("nickName"));
                System.out.println("카테고리 : " + rs.getString("category"));
            }
            rs.close();
            pstmt.close();
            con.close();

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
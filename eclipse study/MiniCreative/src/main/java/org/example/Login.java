package org.example;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;


public class Login {
    User user = new User();

    public int login(String name, String pw) {
        Connection conn = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;

        try {
            conn = DBConnection.getConnection();
            String sql = "select * from user where u_id=? and u_password=?";
            pstmt = conn.prepareStatement(sql);
            pstmt.setString(1, name);
            pstmt.setString(2, pw);
            rs = pstmt.executeQuery();

            if(rs.next()) {
                user.setUserId(rs.getString("u_id"));
                user.setUserPassword(rs.getString("u_password"));
                user.setIdx(rs.getInt("u_idx"));
            } else {
                System.out.println("회원정보가 없습니다.");
                return 0;
            }

        } catch(Exception e) {
            e.printStackTrace();
        }
        return 1;
    }
}

class Join {
    public static void join(String name, String pw) {
        Connection conn = null;
        PreparedStatement pstmt = null;

        try {
            conn = DBConnection.getConnection();
            String sql = "insert into user (`u_id`,`u_password`) "
                    + "values (?,?)";
            pstmt = conn.prepareStatement(sql);
            pstmt.setString(1, name);
            pstmt.setString(2, pw);
            pstmt.executeUpdate();


        } catch(Exception e) {
            e.printStackTrace();
        }
    }
}
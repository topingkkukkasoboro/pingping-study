package org.example;

import java.sql.Connection;
import java.sql.PreparedStatement;

public class Delete {

    public int delete(String name, String password) {
        Connection conn = null;
        PreparedStatement pstmt = null;

        int result = 0;

        try {
            conn = DBConnection.getConnection();
            String sql = "delete from user where u_id=? and u_password=?";
            pstmt = conn.prepareStatement(sql);
            pstmt.setString(1, name);
            pstmt.setString(2, password);
            result = pstmt.executeUpdate();

        } catch(Exception e) {
            e.printStackTrace();
        }
        if(result==1) {
            return 1;
        } else
            return 0;
    }
}

class deletePerson{

    public int deleteperson(int idx) {
        Connection conn = null;
        PreparedStatement pstmt = null;

        int result = 0;

        try {
            conn = DBConnection.getConnection();
            String sql = "delete from user where u_id=? and u_password=?";
            pstmt = conn.prepareStatement(sql);
            pstmt.setInt(1, idx);
            result = pstmt.executeUpdate();

        } catch(Exception e) {
            e.printStackTrace();
        }
        if(result==1) {
            return 1;
        } else
            return 0;

    }
}

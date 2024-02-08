package org.example;

import org.example.enums.Role;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class ENUM_STUDY_DB {

    public void insert() {
        Connection con = null;
        PreparedStatement pstmt = null;
        try {
            con = DriverManager.getConnection("jdbc:mysql://192.168.0.38/kbs", "root", "1234");
            pstmt = con.prepareStatement("insert into enum_study" +
                    "(role) " +
                    "values " +
                    "(?)");
            pstmt.setString(1, Role.ADMIN.toString());
            pstmt.executeUpdate();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            try {
                con.close();
                pstmt.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }
    public void update(int id) {
        Connection con = null;
        PreparedStatement pstmt = null;
        try {
            con = DriverManager.getConnection("jdbc:mysql://192.168.0.38/kbs", "root", "1234");
            pstmt = con.prepareStatement("update enum_study SET ROLE ='user' where id = ?");
            pstmt.setLong(1,id);
            pstmt.executeUpdate();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            try {
                con.close();
                pstmt.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }
    public void select() {
        Connection con = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        try {
            con = DriverManager.getConnection("jdbc:mysql://192.168.0.38/kbs", "root", "1234");
            pstmt = con.prepareStatement("select * from enum_study");
            rs = pstmt.executeQuery();
            while (rs.next()){
                System.out.println(rs.getLong("id"));
                System.out.println(rs.getString("ROLE"));
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            try {
                rs.close();
                con.close();
                pstmt.close();
            } catch (Exception e) {
                e.printStackTrace();
            }

        }
    }
    public void delete(int id) {
        Connection con = null;
        PreparedStatement pstmt = null;

        try {
            con = DriverManager.getConnection("jdbc:mysql://192.168.0.38/kbs", "root", "1234");
            pstmt = con.prepareStatement("delete from enum_study where id = ?");
            pstmt.setLong(1,id);
            pstmt.executeUpdate();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            try {
                con.close();
                pstmt.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }
}
package org.example;

import lombok.AllArgsConstructor;
import lombok.ToString;


@ToString
public class ComFriend extends Friend{

    private String department;

    public ComFriend(String name, String phone) {
        super(name, phone);
    }

    public ComFriend(String name, String department, String phone) {
        super(name,phone);
        this.department = department;


    }
}

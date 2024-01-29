package org.example;

import lombok.AllArgsConstructor;
import lombok.ToString;


@ToString
public class UniFriend extends Friend {

    private String major;

    public UniFriend(String name, String major, String phone) {
        super(name,phone);
        this.major = major;
    }
}

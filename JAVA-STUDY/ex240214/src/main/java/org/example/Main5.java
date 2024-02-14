package org.example;

class Friend{
    String name;
    Company com;

    public Friend(String name, Company com) {
        this.name = name;
        this.com = com;
    }

    public String getName() {
        return name;
    }

    public Company getCom() {
        return com;
    }
}

class Company {
    String name;
    ContInfo continfo;

    public Company(String name, ContInfo continfo) {
        this.name = name;
        this.continfo = continfo;
    }

    public String getName() {
        return name;
    }

    public ContInfo getContinfo() {
        return continfo;
    }
}

class ContInfo {
    String addr;
    String phone;

    public ContInfo(String addr, String phone) {
        this.addr = addr;
        this.phone = phone;
    }

    public String getAddr() {
        return addr;
    }

    public String getPhone() {
        return phone;
    }
}

public class Main5 {
    public static void main(String[] args) {

        Friend friend = new Friend("홍길동",new Company("AA",null));
        Company com = friend.getCom();
        ContInfo coninfo = com.getContinfo();
        String addr = coninfo.getAddr();

        System.out.println("addr = " + addr);
    }
}

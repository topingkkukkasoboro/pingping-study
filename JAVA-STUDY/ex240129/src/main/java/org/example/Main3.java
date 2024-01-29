package org.example;

class DBOx<L,R,T,p>{
    private L l;
    private R r;
    public DBOx(L l, R r) {
        this.l = l;
        this.r = r;
    }
    @Override
    public String toString() {
        return "DBOx{" +
                "l=" + l +
                ", r=" + r +
                '}';
    }
}
public class Main3 {

    public static void main(String[] args) {
        DBOx<String,Integer,String,Object> dbox = new DBOx<>("더블박스",10);
        System.out.println(dbox);
    }
}

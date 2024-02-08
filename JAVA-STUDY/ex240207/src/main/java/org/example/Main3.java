package org.example;

interface Printable{
    public void print();
}
class Paper {
    private String con;
    public void setCon(String con) {
        this.con = con;
    }
    public Printable getprinter() {

        class Printer implements Printable {
            @Override
            public void print() {
                System.out.println(con);

            }
        }
        return new Printer();
    }
    public Printable getprinter1() {

        return new Printable() {
            @Override
            public void print() {
                System.out.println(con);

            }
        };
    }
    public Printable getPrinter2(){
        return () ->{
            System.out.println(con);
        };
    }

    public class Main3 {
        public static void main(String[] args) {
            Paper p = new Paper();
            Printable printable = p.getprinter();


        }
    }
}
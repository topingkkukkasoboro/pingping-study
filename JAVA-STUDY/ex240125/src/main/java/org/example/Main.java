package org.example;

interface Printable{
    int a = 10;
    public void Print(String doc);

    default  public void doA(){
        System.out.println("doA 매서드 입니다.");
    }
}
interface CMYKPrintable extends Printable{
    public void printCMYK(String doc);
}
class Sprint implements Printable{
    @Override
    public void Print(String doc) {
        System.out.println("S Print 출력합니다.");
        System.out.println(doc);
    }
}
class Lprint implements Printable{

    @Override
    public void Print(String doc) {
        System.out.println("L Print 출력합니다.");
        System.out.println(doc);
    }
}

class PRN909 implements CMYKPrintable{
    @Override
    public void Print(String doc) {
        System.out.println("S Print 흑백 출력합니다.");
        System.out.println(doc);
    }
    @Override
    public void printCMYK(String doc) {
        System.out.println("S Print 컬러 출력합니다.");
        System.out.println(doc);

    }
}
public class Main {
    public static void main(String[] args) {
        String doc = "REPORT";

        Sprint sp = new Sprint();
        sp.Print(doc);
        Lprint lp = new Lprint();
        lp.Print(doc);

        Printable p1 = (d) -> {
            System.out.println("람다");
        };
        p1.Print(doc);
        PRN909 prn909 = new PRN909();
        prn909.Print("흑백출력");
        prn909.printCMYK("칼라출력");

        }
    }

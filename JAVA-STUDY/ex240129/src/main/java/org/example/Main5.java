package org.example;


// 타입제한의 효과 // number을 사용했기에 String은 사용불가 하다, Integer만 사용가능
class EBox<T extends Number>{
    private T t;

    public T getT() {
        return t;
    }

    public void set(T t) {
        this.t = t;
    }
}
public class Main5 {

    public static void main(String[] args) {
        EBox<Integer> eBox1 = new EBox<>();
        eBox1.set(100);
        System.out.println(eBox1.getT());

    }
}

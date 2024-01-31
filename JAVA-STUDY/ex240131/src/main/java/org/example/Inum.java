package org.example;

import lombok.ToString;

@ToString
public class Inum implements Comparable {

    private int num;

    public Inum(int num) {
        this.num = num;
    }

    @Override
    public int hashCode() {
        return super.hashCode();
    }

    @Override
    public boolean equals(Object obj) {
        return this.num == ((Inum)obj).num;
    }

    // Arrays.sort 호출하면 기본형타입으로 정렬된다
    //객체형타입(Inum,Person)을 정렬할려고
    // Comparable 상속받아서 compareTo 재정의해야한다.

    //오름차순.. this.num - o.num
    //내림차순.. o.num - this.num

    @Override
    public int compareTo(Object o) {
        //return this.num - ((Inum) o).num; //오름차순
        return ((Inum) o).num - this.num; // 내림차순
    }
}

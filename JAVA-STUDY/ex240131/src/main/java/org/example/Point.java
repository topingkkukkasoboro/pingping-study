package org.example;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@AllArgsConstructor
@ToString

public class Point implements Cloneable {
    private int xpos;
    private int ypos;

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }
}

//    public Point(int xpos, int ypos) {
//        this.xpos = xpos;
//        this.ypos = ypos;
//    }

//    @Override
//    public String toString() {
//        return "Point{" +
//                "xpos=" + xpos +
//                ", ypos=" + ypos +
//                '}';
//    }
//    public int getXpos() {
//        return xpos;
//    }
//
//    public void setXpos(int xpos) {
//        this.xpos = xpos;
//    }
//
//    public int getYpos() {
//        return ypos;
//    }
//
//    public void setYpos(int ypos) {
//        this.ypos = ypos;
//    }


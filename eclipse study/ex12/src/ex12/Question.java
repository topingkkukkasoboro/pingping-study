package ex12;

import java.util.Iterator;

class Accumulater {
	
	static int sum = 0;
	public static void add(int i) {

		sum = sum + i;
		
	}

	public static void showReuslt() {
			System.out.println("sum = " + sum);
	}
}

public class Question {
	public static void main(String[] args) {
		
		for (int i = 0; i < 10; i++) {
			Accumulater.add(i);
		}
		Accumulater.showReuslt();
	}

}

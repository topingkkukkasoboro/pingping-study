package ex06;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class txt {
	public static void main(String[] args) throws FileNotFoundException   {
		Scanner sc = new Scanner(new File("src/abc.txt"));
		
		// txt 파일을 생성해서 읽어라
		
		
		int a = sc.nextInt();
		System.out.println("a = " + a);
		int b = sc.nextInt();
		System.out.println("b = " + b);
	}

}

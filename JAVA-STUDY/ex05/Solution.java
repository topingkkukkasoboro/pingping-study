package ex05;

import java.util.Scanner;

public class Solution{
	public static String solution(String my_string, int k) {
		
		String result = "";
		for(int i = 0; i < k; i++) {
			result = result + my_string;
		}
		return result;
	
	}
	public static void main(String[] args) {
		String my_string = "abcde";
		int num = 10;
		
		String temp = solution(my_string,num);
		System.out.println(temp);
	}
}


package ex09;

import java.util.Arrays;
import java.util.Scanner;

public class main {
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);

    int n = sc.nextInt(); // n은 배열의 길이로 쓰고
    int x = sc.nextInt(); // x는 보다 작은 수를 찾을 숫자
    int[] brr = new int[n]; // brr의 길이는 n
    int[] arr = new int[n]; // arr의 길이는 n


    for (int i = 0; i < n; i++) {
        arr[i] = sc.nextInt(); // arr[i]마다 스캔해서 입력
    }
    for (int i = 0; i <n; i++) {
        if (arr[i]<x)
           brr[i] = arr[i];

    }
    System.out.println(Arrays.toString(brr));

    }

 }



package ex07;

public class Ex06 {
	public static void main(String[] args) {
		int[] arr = {10,20,30,40,50};
		
		String a ="abcdef";
		System.out.println(a.length()); //뭐뭐.length()는 배열 또는 문자열의 길이이다
		
		for(int i = 0; i < arr.length; i++) 
			System.out.println(arr[i]);
			
			System.out.println();
			
			int sum = 0;
			
			for(int temp: arr) {
				System.out.println(temp);
				sum = sum + temp;
			}
			System.out.println(sum);
			
		String[] arr1 = {"aa, bb, cc, dd"};
		String sumstr ="";
		
		for(String temp : arr1) {
			System.out.println(temp);
			sumstr += temp;
	} 
		System.out.println();
	}	
}

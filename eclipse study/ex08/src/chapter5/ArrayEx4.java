package chapter5;

import java.util.Arrays;

class ArrayEx4 {
	public static void main(String[] args) {
		char[] abc = { 'A', 'B', 'C', 'D'};
		char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
		
		System.out.println(abc);
		System.out.println(num);

		int[]a = {1,2,3,4};
		System.out.println(a);
	
		char[] result = new char[abc.length+num.length];
		
		System.out.println(result.length);
		
		int resultindex = 2;
		
		result[resultindex++] = abc[0];
		result[resultindex++] = abc[1];
		result[resultindex++] = abc[2];
		result[resultindex++] = abc[3];
		
		System.out.println(Arrays.toString(result));
			
			System.arraycopy(abc, 0, abc.length, num length);
			
		
		System.out.println(Arrays.toString(result));
		
		System.arraycopy(abc, 0, result, 0, abc.length);
		System.out.println(result);
		
		
		System.arraycopy(num, 0, result, abc.length, num.length);
		System.out.println(result);


		System.arraycopy(abc, 0, num, 0, abc.length);	
		System.out.println(num);


		System.arraycopy(abc, 0, num, 6, 3);
		System.out.println(num);
	}
}

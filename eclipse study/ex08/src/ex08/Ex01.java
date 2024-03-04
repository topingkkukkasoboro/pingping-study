package ex08;

public class Ex01 {

	public static void main(String[] args) {
		String answer = "";
		String a = "aaaaa";
		String b = "bbbbb";
		char [] ac = a.toCharArray();
		char [] bc = b.toCharArray();
		
		for(int i = 0; i < ac.length; i++) { // i는 0부터 6전까지 반복해라 // 0,1,2,3,4,5
			//System.out.print(ac[i]); // ac[0], ac[1], ac[2], ac[3], ac[4], ac[5]
		    //System.out.print(bc[i]); // bc[0], bc[1], bc[2], bc[3], bc[4], bc[5]
		    answer = answer + ac[i] + bc[i];
		
		}
		System.out.println("answer = " + answer);
		
		//for (char temp : ac)
		//System.out.println(temp);

	}
	
}

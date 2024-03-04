package chapter5;

class ArrayEx1 {
	public static void main(String[] args) { 
		int[] score = new int[5]; // score에 배열은 0,1,2,3,4 자리까지 있다
		int k = 1;

		score[0] = 50;
		score[1] = 60;
		score[k+1] = 70;   
		score[3] = 80;
		score[4] = 90;

		int tmp = score[k+2] + score[4];  

		for(int i=0; i < 5; i++) {
			System.out.printf("score[%d]:%d%n",i, score[i]);		
		}

		System.out.printf("tmp:%d%n", tmp);
		System.out.printf("score[%d]:%d%n",7,score[4]);
	} 
}

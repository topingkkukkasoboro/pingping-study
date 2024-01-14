package ex07;

public class test {
	public static void main(String[] args) {
		int[] array = {1, 2, 3, 3, 3, 4};
		int answer = 0; // answer에 0으로 초기화
        int[] ary = new int[1001]; //0 이상 1000 미만의 범위에서 각 숫자의 빈도를 저장할 배열 // 빈도는 수가 중복되는 갯수

        for (int i = 0; i < array.length; i++) {  // i가 0일때 // i가 array의 배열수보다 클떄까지 // i에 1씩 더하자
            ary[array[i]]++; // array의 배열 갯수를 ary에 저장한다
            System.out.println(ary[array[i]]); // 1 1 3 1이 나옴
	}

}
}

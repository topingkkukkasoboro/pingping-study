import java.util.Arrays;

public class Ex03 {

    public static void main(String[] args) {

        int []a = {80,90,100};
        int [][] score = {{10,20,30},{40,50,60,70}}; // 2차원 배열 작성법

        System.out.println(score.length); // 배열이 2개니 2출력
        System.out.println(score[0].length); // score의 첫번째 배열 길이
        System.out.println(score[1].length); // score의 두번재 배열 길이

        score[1] = a; // score의 1번배열은 a 배열이다
        System.out.println(score[1].length);

        a[0] = 300;

        System.out.println(Arrays.toString(score));
    }
}

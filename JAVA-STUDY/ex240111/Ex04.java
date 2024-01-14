public class Ex04 {
    public static void main(String[] args) {

        int[][] score = {{10,20,30,50,60},{40,50,60},{70,80,90,100}};

        //모든수의 합을 구하시오
        int sum = 0; // sum을 0으로 초기화
        for (int i = 0; i < score.length ; i++) { // i가 score의 길이가 될때까지
            for (int j = 0; j < score[i].length ; j++) { // j가 score의 j번 배열 길이가 될때까지
                    sum += score[i][j]; // sum에다가 score의 i번 배열의 j번 숫자를 더해 넣어라
            }
        }
        System.out.println(sum);
    }
}

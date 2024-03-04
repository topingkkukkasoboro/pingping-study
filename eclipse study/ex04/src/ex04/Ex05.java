package ex04;

public class Ex05 {
	public static void main(String[] args) {
		   int i = 3;
		      int k = 1;
		      
		      switch (i) { // 스위치구문은 ()안의 값과 일치하는 케이스로 가서 진행된다.
		      case 1:
		         k += 1;
		      case 2:
		         k++;
		      case 3:
		         k = 0;  // 0임으로 k = 0 // 뒤에 break;를 사용하면 해당 케이스에서 빠져나온다.
		      case 4:
		         k += 3; // k = k + 3
		      case 5:
		         k -= 10; // k = k - 10
		      default:
		         k--; // k = k - 1
		      }
		      System.out.print(k);
		   }
		}
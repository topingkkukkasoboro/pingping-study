package mariadb;

import java.util.*;

public class miniproject {

	public static void main(String[] args) {
		
		System.out.println("주소록");

		Scanner scan = new Scanner(System.in);

		ArrayList<person> personList = new ArrayList<>();
		while (true) {

			
			System.out.println(" ");
			System.out.println("1.추가");
			System.out.println(" ");
			System.out.println("2.검색");
			System.out.println(" ");
			System.out.println("3.카테고리 검색");
			System.out.println(" ");
			System.out.println("4.종료");

			String input = scan.next();

			if (input.equals("1")) {
				System.out.println(" ");
				System.out.println("이름을 입력하세요");
				String name = scan.next();
				System.out.println("나이를 입력하세요");
				String age = scan.next();
				System.out.println("성별을 입력하세요");
				String gender = scan.next();
				System.out.println("전화번호를 입력하세요");
				String phoneNumber = scan.next();
				System.out.println("MBTI 입력하세요");
				String MBTI = scan.next();
				System.out.println("주소를 입력하세요");
				String adress = scan.next();
				System.out.println("별명을 입력하세요");
				String nickName = scan.next();
				System.out.println("카테고리를 입력하세요");
				String group = scan.next();

				person person = new person(name, age, gender, phoneNumber, MBTI, adress, nickName, group);
				personList.add(person);

				System.out.println(" ");
				System.out.println(person);
				System.out.println(" ");

			} else if (input.equals("2")) {
				System.out.println("검색할 이름을 입력하세요");
				String searchName = scan.next();

				boolean found = false;
				for (person person : personList) {
					if (person.getName().equals(searchName)) {
						System.out.println("검색 결과:");
						System.out.println(person);
						found = true;
						break;
					}
				}

				if (!found) {
					System.out.println("그런 사람 없어요");
				}
			} else if (input.equals("3")) {
				System.out.println("그룹을 입력하세요");
				String searchGroup = scan.next();

				boolean found = false;
				for (person person : personList) {
					if (((mariadb.person) person).getGroup().equalsIgnoreCase(searchGroup)) {
						System.out.println(" ");
						System.out.println("그룹 검색 결과");
						System.out.println(" ");
						System.out.println(person);
						found = true;
					}
				}

				if (!found) {
					System.out.println("해당 그룹에 속한 사람이 없어요");
				}
			} else if (input.equals("4")) {
				System.out.println("종료");
				break;
			}
		}
	}
}
package myclass;


import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Setter
@Getter
@AllArgsConstructor // 자동 완성
@ToString


public class Member {

    private String name;
    private int age;

}

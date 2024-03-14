package com.mh.restapi03.users;

import com.fasterxml.jackson.annotation.JsonFormat;
import com.fasterxml.jackson.annotation.JsonIgnore;
import io.swagger.v3.oas.annotations.media.Schema;
import jakarta.persistence.*;
import lombok.*;

import java.time.LocalDateTime;

@Entity // 테이블
@ToString
@Getter
@Setter
@Builder
@AllArgsConstructor
@NoArgsConstructor
@Table(name = "users")
@Schema(description = "User Table에 관한 내용입니다")
public class User {


    //sequence 테이블을생성해서 기본키 관리
    //identity auto_increment 자동증가

    @Id // id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Schema(title ="사용자 id",description = "table에서 자동생성되는 컬럼")
    private Long id;

    @Schema(title = "사용자 username", description = "사용자이름을 넣어주시면 됩니다")
    @Column(length = 50)
    private String username;

    @Schema(title = "사용자 email",description = "eamil을 넣어주시고 중복되면 안됩니다")
    @Column(length = 50, unique = true)//unique = true 중복나면 실패하겠다 // unique키 등록
    private String email;
    @JsonIgnore
    private String password;

    @Enumerated(EnumType.STRING)
    //@Enumerated(EnumType.ORDINAL) 하면 male이 0, female은 1로 들어간다
    //@Enumerated(EnumType.STRING) 하면 male, female로 작성가능하다
    private Gender gender;

    //시간 넣는거 datetime
    @JsonFormat(pattern = "yyyy/MM/dd HH:mm:ss")
    private LocalDateTime wdate;
}

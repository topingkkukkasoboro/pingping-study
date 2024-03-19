package com.mh.restapi05.member;

import jakarta.persistence.*;
import lombok.*;
import net.sf.jsqlparser.expression.DateTimeLiteralExpression;
import org.hibernate.Length;
import org.springframework.data.annotation.CreatedDate;
import org.springframework.data.annotation.LastModifiedDate;

import java.time.LocalDateTime;

@Entity
@Getter
@NoArgsConstructor
@AllArgsConstructor
@Builder
@ToString
@Setter
public class Member {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(length = 50, nullable = false)
    private String username;

    private String password;

    @Column(length = 50, unique = true)
    private String email;

    @Enumerated(EnumType.STRING) // user랑 admin만 들어가게
    private Role role;

    @CreatedDate// insert했던 시간
    private LocalDateTime writeDate;

    @LastModifiedDate // 수정, 업데이트한 시간
    private LocalDateTime modifyDate;
}

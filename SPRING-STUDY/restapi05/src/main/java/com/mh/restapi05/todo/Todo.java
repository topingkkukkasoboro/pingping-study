package com.mh.restapi05.todo;

import com.mh.restapi05.member.Member;
import jakarta.persistence.*;

@Entity
@Table(name = "todo")
public class Todo {

    @Id
    @GeneratedValue(strategy = GenerationType.SEQUENCE)
    @Column(name = "id",nullable = false)
    private Long id;
    private String todo;
    @ManyToOne// 자동으로 id를 뒤에 붙여서 생성한다
    private Member member;

}

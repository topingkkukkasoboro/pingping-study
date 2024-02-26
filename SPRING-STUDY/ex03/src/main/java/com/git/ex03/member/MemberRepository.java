package com.git.ex03.member;

import java.util.Collection;
import java.util.HashMap;
import java.util.Map;

public class MemberRepository {
    Map<String,Member> map = new HashMap<>();

    public void insert(Member member) {
        map.put(member.getEmail(),member);
        System.out.println("확인2");
    }

    public Collection<Member> select() {
        return map.values();
    }
}

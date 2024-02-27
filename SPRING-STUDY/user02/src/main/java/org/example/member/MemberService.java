package org.example.member;

import org.example.component.AABBService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Service;

import java.util.Collection;

//alt+ 1하면 project로 이동
//alt+insert누르면 새로 생성
//esc누르면 소스로 이동
//파일간의 이동할때 ctrl + tab
// shift + shift 선택해서 이동
@Service
public class MemberService {

    @Autowired
    @Qualifier("AABBService")
    AABBService aabbService;
    @Autowired
    MemberDAO memberDAO;

    // Member Map 등록하러 가야함
    public void Regist(Member member){
    memberDAO.insert(member);
    }
    //내용을 출력
    public void list(){
        Collection<Member> collection = memberDAO.select();
        collection.forEach(System.out::println);
    }
}

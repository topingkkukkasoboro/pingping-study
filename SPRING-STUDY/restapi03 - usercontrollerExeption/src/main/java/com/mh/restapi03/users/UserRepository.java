package com.mh.restapi03.users;

import lombok.Getter;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;


@Repository // primary키로 id 관리
public interface UserRepository extends JpaRepository<User, Long> {


//select * from user where email =?을 만들어줌

public User findByEmail(String email);

}

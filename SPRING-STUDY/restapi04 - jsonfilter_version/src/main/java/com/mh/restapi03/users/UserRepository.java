package com.mh.restapi03.users;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;


@Repository // primary키로 id 관리
public interface UserRepository extends JpaRepository<User, Long> {


//select * from user where email =?을 만들어줌
public User findByEmail(String email);
// select * from user where username like %길동% 처럼 찾아줌
    // select * from user where username like %길동% or email like %%
public List<User> findByUsernameContainingOrEmailContaining(String username, String email);

}

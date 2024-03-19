package com.mh.restapi05.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.provisioning.InMemoryUserDetailsManager;

@Configuration
public class WebMvcConfig {

    @Bean
    public PasswordEncoder passwordEncoder(){
        return new BCryptPasswordEncoder();
    }
/*    @Bean
    public UserDetailsService userDetailsService(){
        //유저 관리하는 매니저 클래스
        InMemoryUserDetailsManager userDetailsManager = new InMemoryUserDetailsManager();
        //로그인 할 수 있는 유저 생성
        UserDetails userDetails = User.withUsername("user")
                .password(passwordEncoder().encode("1234"))
                .roles("USER").build();
        //유저관리하는 매니저 클래스 유저 등록
        userDetailsManager.createUser(userDetails);
        // 유저관리 하는 매니저 ioc 컨테이너에 등록 -> securityConfig에서 사용
        return userDetailsManager;
    }*/


}

package com.mh.restapi05.config;

import lombok.RequiredArgsConstructor;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequiredArgsConstructor
public class WebMvcConfigTest {

    private final PasswordEncoder passwordEncoder;

    @GetMapping("/test")
    public String test(){
        String password = passwordEncoder.encode("1234");
        return password;
    }
}
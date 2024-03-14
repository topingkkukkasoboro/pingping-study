package com.mh.restapi03.main;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class MainController {

    @GetMapping("/")
    public String hello() {
        return "hello";
    }
    @PostMapping("greet")
    public String great(String param) {
        return "greet" + param;
    }
}

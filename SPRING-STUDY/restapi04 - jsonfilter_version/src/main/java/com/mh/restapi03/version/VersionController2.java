package com.mh.restapi03.version;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api/v2")
public class VersionController2 {

    // api/v1 = hello를 보냄
    // api/v2 = hello2를 보냄
    @GetMapping("hello")
    public String hello()
    {
        return "hello2";
    }


}

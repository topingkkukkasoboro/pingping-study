package com.example.chpter066;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class MainController {

    @GetMapping("main")
    public String main(){
        return "MAIN";
    }

}
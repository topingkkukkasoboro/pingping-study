package com.example.chpter066.conf;

import com.example.chpter066.inter.Myintercepter;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.config.annotation.InterceptorRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;

@Configuration
public class MywebConfig implements WebMvcConfigurer {

    @Autowired
    private Myintercepter myintercepter;

    @Override
    public void addInterceptors(InterceptorRegistry registry){
        registry.addInterceptor(myintercepter).addPathPatterns("/member/list");
    }

}

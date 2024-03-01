package com.example.chpter066.conf;

import com.example.chpter066.filter.MyFilter;
import lombok.RequiredArgsConstructor;
import org.springframework.boot.web.servlet.FilterRegistrationBean;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import java.util.Arrays;

@Configuration
@RequiredArgsConstructor
public class MyfilterConfig {
    private final MyFilter myFilter;
    @Bean
    public FilterRegistrationBean<MyFilter> myFilterFilterRegistrationBean(){
        FilterRegistrationBean<MyFilter> myFilterFilterRegistrationBean
                =new FilterRegistrationBean<>();
        myFilterFilterRegistrationBean.setFilter(new MyFilter());
        myFilterFilterRegistrationBean.setUrlPatterns(Arrays.asList("/member/list"));
        return myFilterFilterRegistrationBean;
    }
}

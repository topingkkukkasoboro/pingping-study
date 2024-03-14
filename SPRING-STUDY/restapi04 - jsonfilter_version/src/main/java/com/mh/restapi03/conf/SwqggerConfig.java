package com.mh.restapi03.conf;

import io.swagger.v3.oas.annotations.OpenAPIDefinition;
import io.swagger.v3.oas.annotations.info.Info;
import org.springdoc.core.models.GroupedOpenApi;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import javax.swing.*;

@OpenAPIDefinition(
     info =@Info(title ="kbs가 만든 USER,MAIN",
                description = "유저 등록 수정 삭제 보수",
                version = "v1.0.0")
)
@Configuration
public class SwqggerConfig {

    @Bean
    public GroupedOpenApi groupedOpenApi(){
        String[] paths = {"/users/**"};

        return GroupedOpenApi.builder()
                .group("UserController만 보이게 됩니다")
                .pathsToMatch(paths)
                .build();
    }
}



package com.git.ex02;

import com.git.ex02.conf.MyConfig;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;

@SpringBootApplication
public class Ex02Application {

	public static void main(String[] args) {
		ApplicationContext context = SpringApplication.run(Ex02Application.class, args);
		String str[] = context.getBeanDefinitionNames();
		for (String temp : str){
			System.out.println(str);
		}
	}


}

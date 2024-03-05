package co_.ph.restapi01;


import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;

import java.lang.reflect.Array;
import java.util.Arrays;


@SpringBootApplication
public class Restapi01Application {

	public static void main(String[] args) {
		ApplicationContext context = SpringApplication.run(Restapi01Application.class, args);
		Arrays.stream(context.getBeanDefinitionNames()).filter(s -> s.contains("Main")).forEach(System.out::println);

	}


}

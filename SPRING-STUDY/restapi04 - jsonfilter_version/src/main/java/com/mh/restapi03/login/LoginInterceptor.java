package com.mh.restapi03.login;

import com.mh.restapi03.exception.ErrorCode;
import com.mh.restapi03.exception.UsersException;
import com.mh.restapi03.users.User;
import com.mh.restapi03.users.UserRepository;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import lombok.RequiredArgsConstructor;
import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.HandlerInterceptor;
import org.springframework.web.servlet.config.annotation.InterceptorRegistry;

@Configuration
@RequiredArgsConstructor
public class LoginInterceptor implements HandlerInterceptor {

    private final UserRepository userRepository;
    @Override
    public boolean preHandle(HttpServletRequest request, HttpServletResponse response, Object handler) throws Exception {
        System.out.println("일로오나");
        String id = request.getHeader("id");
        String password = request.getHeader("password");
        String email = request.getHeader("email");

        System.out.println(id);
        System.out.println(password);
        System.out.println(email);

        User dbuser =userRepository.findByEmailAndPassword(email,password);
        if(dbuser == null){
            throw  new UsersException(ErrorCode.LOHINFAILED);
        }


        return true;
    }
}

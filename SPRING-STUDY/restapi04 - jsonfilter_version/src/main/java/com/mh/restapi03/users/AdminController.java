package com.mh.restapi03.users;

import com.fasterxml.jackson.databind.ser.FilterProvider;
import com.fasterxml.jackson.databind.ser.impl.SimpleBeanPropertyFilter;
import com.fasterxml.jackson.databind.ser.impl.SimpleFilterProvider;
import com.mh.restapi03.exception.ErrorCode;
import com.mh.restapi03.exception.UsersException;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.BeanUtils;
import org.springframework.http.converter.json.MappingJacksonValue;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("admin")
@RequiredArgsConstructor
public class AdminController {
    //ioc 컴테이너 객체 가져오는 방법
    //autowired 사용 안하고 가능 
    // 이게 정석이라고 함
    private final UserRepository userRepository;

    /*    @GetMapping("users/id")
        public User getUserbyId(Long id) throws UsersException {

            Optional <User> user = Optional.ofNullable(userRepository.findById(id).orElseThrow(
                    () -> new UsersException(ErrorCode.NOTFOUND)
            ));

            return new User();
        }*/
    @GetMapping("users/{id}")
    public MappingJacksonValue getUserbyId(@PathVariable  Long id) {
/*
        Optional<User> user = userRepository.findById(id);
        if(user.isEmpty()){
            throw new UsersException(ErrorCode.NOTFOUND);
        }*/
        User user = userRepository.findById(id).orElseThrow(() -> new UsersException(ErrorCode.NOTFOUND));

        AdiminUser adminUser = new AdiminUser();
        BeanUtils.copyProperties(user, adminUser);

        MappingJacksonValue mappingJacksonValue = new MappingJacksonValue(adminUser);
        FilterProvider filterProvider = new SimpleFilterProvider().addFilter("AdminUser",
                SimpleBeanPropertyFilter.filterOutAllExcept("username","email","password"));
        mappingJacksonValue.setFilters(filterProvider);

        return mappingJacksonValue;
    }

    @DeleteMapping("users/{id}")
    public User deleteUserbyId(Long id) {

        return new User();

    }

}

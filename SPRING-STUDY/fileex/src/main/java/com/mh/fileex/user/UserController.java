package com.mh.fileex.user;

import jakarta.validation.Valid;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.BeanUtils;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import static org.springframework.http.MediaType.MULTIPART_FORM_DATA_VALUE;
import static org.springframework.util.MimeTypeUtils.APPLICATION_JSON_VALUE;


@RestController
@RequestMapping("/api/user")
@RequiredArgsConstructor
public class UserController {

    private final UserService userService;

    @PostMapping(value = "/join", produces = APPLICATION_JSON_VALUE,
            consumes = MULTIPART_FORM_DATA_VALUE)
    public String join(@Valid @RequestPart(value = "userDto") UserDto userDto,
                       @RequestPart(value = "file") MultipartFile imageFile) {
        System.out.println(userDto);
        System.out.println(imageFile.getOriginalFilename());
        // UserDto를 user로 반환한다
        User user = new User();
        BeanUtils.copyProperties(userDto, user);
        System.out.println(user);
        userService.join(user, imageFile);
        return "회원가입";
    }

    @PostMapping("/login")
    public String login(@RequestBody UserDto userDto) {
        String result = userService.logincheck(userDto);
        return result;
    }
}

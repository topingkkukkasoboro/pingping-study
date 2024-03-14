package com.mh.restapi03.users;

import com.fasterxml.jackson.annotation.JsonFormat;
import jakarta.persistence.Column;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import jakarta.validation.constraints.*;
import lombok.*;

import java.time.LocalDateTime;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
@ToString
//속성만들고 유효성검사
public class UserDto {
    private Long id;

    @NotBlank
    private String username;
    @Size(min = 5,max = 50)
    private String email;
    //@Min(5)
    private String password;
    @NotNull
    private Gender gender;
    @JsonFormat(pattern = "yyyy/MM/dd HH:mm:ss")
    private LocalDateTime wdate;
    public static User of(UserDto userdto){
        User user = new User();
        user.setId(userdto.getId());
        user.setUsername(userdto.getUsername());
        user.setEmail(userdto.getEmail());
        user.setPassword(userdto.getPassword());
        user.setGender(userdto.getGender());
        user.setWdate(LocalDateTime.now());
        return user;
    }
}

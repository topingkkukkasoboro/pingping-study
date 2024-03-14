package com.mh.restapi03.users;

import com.mh.restapi03.exception.ErrorCode;
import com.mh.restapi03.exception.UsersException;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.Parameter;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import io.swagger.v3.oas.annotations.tags.Tag;
import jakarta.validation.Valid;
import lombok.RequiredArgsConstructor;
import org.modelmapper.ModelMapper;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.bind.annotation.*;
import java.time.LocalDateTime;
import java.util.List;

// ctrl + shift + x 한글 번역
// ctrl + shift + f 클래스로 변수 빼기


@RequiredArgsConstructor
@RestController
@Tag(name = "user-controller",description = "유저 조회 등록 수정 삭제")
public class UserController {

    private final UserService userService;
    private final UserRepository userRepository;

    @PostMapping("users") // 사용자 등록
    public ResponseEntity <User> addUser(@RequestBody @Valid UserDto userDto) {

        User user = UserDto.of(userDto);
        User dbuser = userService.regist(user);
        return ResponseEntity.status(HttpStatus.CREATED).body(dbuser);
    }
    @GetMapping("users/{id}") // 특정 id 조회
    public ResponseEntity<User> getUserById(
            @Parameter(description = "조회하고 싶은 사용자 id를 입력하세요"
                    ,name = "사용자 id"
                    ,required = true)
            @PathVariable Long id){
        System.out.println(id);

        User user = userService.getUserById(id);

        return ResponseEntity.status(HttpStatus.OK).body(user);
    }
    @Operation(summary = "사용자 전체 목록 보기",description = "사용자 전체 정보 조회할수있습니다")
    @ApiResponses({
            @ApiResponse(responseCode = "200",description = "ok"),
            @ApiResponse(responseCode = "404",description = "사용자들이 없을때 나옵니다")
    })
    @GetMapping("users") // 사용자 조회
    public ResponseEntity<List<User>> getAllUsers(){



        List<User> list = userService.getAllusers();
        if(list.size() == 0){
            throw new UsersException(ErrorCode.NOTFOUND);
        }
        return ResponseEntity.ok(list);
    }
    @PutMapping("users")
    public ResponseEntity<User> updateUser(@RequestBody @Valid UserDto userDto){
        ModelMapper mapper = new ModelMapper();
        User user = mapper.map(userDto, User.class);
        user.setWdate(LocalDateTime.now());
        User dbuser = userService.Updateuser(user);

        return ResponseEntity.status(HttpStatus.ACCEPTED).body(new User());
    }
    @DeleteMapping("users/{id}")
    public ResponseEntity<String> deleteUser(@PathVariable Long id){
        userService.delete(id);

        return ResponseEntity.status(HttpStatus.ACCEPTED).body("삭제됨");
    }
    @DeleteMapping("users/all")
    public ResponseEntity<String> deleteAllUser(@PathVariable Long id){
        userService.alldelete();
        return ResponseEntity.status(HttpStatus.ACCEPTED).body("전부삭제됨");
    }
    @Transactional(readOnly = true) // 영구속성에 의해서 setter 매서드 사용시 dbupdate 실행됨
    @GetMapping("users/tran")
    public String userstran(){

        User dbUser = userRepository.findById(1L).orElseThrow();
        dbUser.setUsername("김길동");
        dbUser.setEmail("aa@naver.com");
        return "tran";
    }
}

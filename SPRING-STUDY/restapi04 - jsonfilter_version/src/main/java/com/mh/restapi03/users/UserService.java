package com.mh.restapi03.users;

import com.mh.restapi03.exception.ErrorCode;
import com.mh.restapi03.exception.LogicException;
import com.mh.restapi03.exception.UsersException;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
@RequiredArgsConstructor
public class UserService {

    private final UserRepository userRepository;

    public User regist(User user){
        //중복처리
        // 해당되는 email이 있으면 중복나서 에러
        User emailUser = userRepository.findByEmail(user.getEmail());
        if(emailUser != null){
            //System.out.println(user.getEmail() +"중복된 이메일이 있습니다");
            throw new LogicException(ErrorCode.DUPLICATE);
        }

    User dbuser = userRepository.save(user);
    return dbuser;
    }

    public List<User> getAllusers() {
        List<User> list = userRepository.findAll();
        return list;
    }
    public User getUserById(Long id){
        Optional<User> optionalUser = userRepository.findById(id);
        if(optionalUser.isEmpty()){
            throw new UsersException(ErrorCode.NOTFOUND);
        }
        else{
            return optionalUser.get();
        }
    }
    public User Updateuser(User user){

        User emailUser = userRepository.findByEmail(user.getEmail());
        if (emailUser == null){
            throw new UsersException(ErrorCode.NOTUPDATEEMAIL);
        }
        emailUser.setWdate(user.getWdate());
        emailUser.setUsername(user.getUsername());
        emailUser.setPassword(user.getPassword());
        emailUser.setGender(user.getGender());
        User dbuser = userRepository.save(user);
        return dbuser;
    }

    public void delete(Long id) {
        //해당되는 아이디가 있으면 삭제해야한다
        // 해당되는 아이디가 없으면 삭제할 유저가 없다
        Optional<User> dbUser = userRepository.findById(id);
        if(dbUser.isEmpty()){
            //삭제할 유저가 없다면 알려준다
            throw new UsersException(ErrorCode.NOTFOUND);
        }
        User getUser = dbUser.get();
          userRepository.delete(getUser);
    }
    public void alldelete(){
        userRepository.deleteAll();
    }
}

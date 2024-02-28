package org.example.component;

import org.springframework.beans.factory.DisposableBean;
import org.springframework.beans.factory.InitializingBean;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class MemberService implements InitializingBean, DisposableBean {
@Autowired
private MemeberRepository memeberRepository;

    @Override
    public void afterPropertiesSet() throws Exception {
        System.out.println("IOC컨테이너 들어갈때...");
    }

    @Override
    public void destroy() throws Exception {
        System.out.println("IOC컨테이너 없어질때...");
    }

    public void regist() {
        memeberRepository.insert();
    }
}

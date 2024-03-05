package co_.ph.restapi01.main;

import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ResponseBody;

@RequiredArgsConstructor
@Controller
public class MainController {
    private final MainService mainService = new MainService();
    @GetMapping("main")
    public String main() {
        System.out.printf(String.valueOf(mainService));
        return "main";

    }

    @GetMapping("mainapi")
    public @ResponseBody String mainapi() {
        return "mainapi";
    }

}

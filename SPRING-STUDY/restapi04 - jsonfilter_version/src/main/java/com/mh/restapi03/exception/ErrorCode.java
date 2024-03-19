package com.mh.restapi03.exception;
import lombok.Getter;
import org.springframework.http.HttpStatus;

@Getter
public enum ErrorCode {
    DUPLICATE(HttpStatus.BAD_REQUEST,"A001","중복된 내용이 있습니다"),
    NOTFOUND(HttpStatus.NOT_FOUND, "B001","해당되는 내용이 없습니다"),
    TEST(HttpStatus.BAD_GATEWAY,"C001","TEST입니다"),
    NOTUPDATEEMAIL(HttpStatus.NOT_FOUND, "NOTUPDATE","수정할 email이 없습니다"),
    LOHINFAILED(HttpStatus.UNAUTHORIZED,"LOGINFAIL","이메일패스워드확인하세요")
    ;

    private HttpStatus httpStatus;
    private String errorcode;
    private String message;
    ErrorCode(HttpStatus httpStatus, String errorcode, String message) {
        this.httpStatus = httpStatus;
        this.errorcode = errorcode;
        this.message = message;
    }
}

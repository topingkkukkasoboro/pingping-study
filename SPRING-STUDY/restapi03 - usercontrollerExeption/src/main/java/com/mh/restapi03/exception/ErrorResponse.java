package com.mh.restapi03.exception;

import com.fasterxml.jackson.annotation.JsonFormat;
import lombok.Builder;
import lombok.Getter;
import org.springframework.http.HttpStatus;

import java.time.LocalDateTime;

@Getter
@Builder

public class ErrorResponse {

    private String errorcode;
    private String errormessage;
    @JsonFormat(pattern = "yyyy/MM/dd HH:mm:ss")
    private LocalDateTime errordatetime;

}

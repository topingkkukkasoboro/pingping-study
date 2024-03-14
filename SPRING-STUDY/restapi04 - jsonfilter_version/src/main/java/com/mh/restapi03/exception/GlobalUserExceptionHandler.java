package com.mh.restapi03.exception;

import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.HttpStatusCode;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ControllerAdvice;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.context.request.WebRequest;
import org.springframework.web.servlet.mvc.method.annotation.ResponseEntityExceptionHandler;
import java.time.LocalDateTime;

@ControllerAdvice
public class GlobalUserExceptionHandler extends ResponseEntityExceptionHandler {

    @ExceptionHandler(LogicException.class)
    public final ResponseEntity<ErrorResponse> hanleLogException(LogicException ex) {

        //ErrorCode errorCode = ex.getErrorCode();

        ErrorResponse errorResponse = ErrorResponse.builder()
                .errorcode(ex.getErrorCode().getErrorcode())
                .errormessage(ex.getErrorCode().getMessage())
                .errordatetime(LocalDateTime.now())
                .build();
        return ResponseEntity.status(ex.getErrorCode().getHttpStatus()).body(errorResponse);
    }
    @ExceptionHandler(Exception.class)
    public final ResponseEntity<ErrorResponse> handleException(UsersException ex){

        ErrorCode errorCode = ex.getErrorCode();

        ErrorResponse errorResponse
                = ErrorResponse.builder()
                .errormessage(ex.getErrorCode().getMessage())
                .errorcode(ex.getErrorCode().getErrorcode())
                .errordatetime(LocalDateTime.now())
                .build();

        return ResponseEntity.status(HttpStatus.NOT_FOUND).body(errorResponse);

    }

    @Override
    protected ResponseEntity<Object> handleMethodArgumentNotValid(MethodArgumentNotValidException ex, HttpHeaders headers, HttpStatusCode status, WebRequest request) {
        System.out.println("유효성 실패" + ex.getMessage());
        System.out.println("유효성 실패" + ex.getBindingResult());

        ErrorResponse errorResponse = ErrorResponse
                .builder()
                .errorcode(HttpStatus.BAD_REQUEST.toString())
                .errormessage(ex.getBindingResult().toString())
                .errordatetime(LocalDateTime.now())
                .build();

        return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(errorResponse);
    }


}

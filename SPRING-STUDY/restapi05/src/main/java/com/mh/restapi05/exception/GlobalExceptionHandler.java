package com.mh.restapi05.exception;

import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.HttpStatusCode;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.Errors;
import org.springframework.validation.FieldError;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ControllerAdvice;
import org.springframework.web.context.request.WebRequest;
import org.springframework.web.servlet.mvc.method.annotation.ResponseEntityExceptionHandler;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

@ControllerAdvice
public class GlobalExceptionHandler extends ResponseEntityExceptionHandler {

    @Override
    protected ResponseEntity<Object> handleMethodArgumentNotValid(MethodArgumentNotValidException ex,
                                                                  HttpHeaders headers,
                                                                  HttpStatusCode status,
                                                                  WebRequest request){
        System.out.println("이리온나");

        List<String> errorMessages = ex.getBindingResult().getFieldErrors()
                .stream()
                .map(error -> error.getField() + ": " + error.getDefaultMessage()) //
                .collect(Collectors.toList());

        List<String> errorMessage = new ArrayList<>();
        List<String> errorReason = new ArrayList<>();

        List<FieldError> list = ex.getBindingResult().getFieldErrors();
        for (FieldError error : list){
            System.out.println("error.getField() : " + error.getField());
            System.out.println("error.getDefaultMessage() : " + error.getDefaultMessage());
            System.out.println("error.getCode() : " + error.getCode());
        }
        list.stream().forEach(error -> {
            System.out.println("error.getField() : " + error.getField());
            System.out.println("error.getDefaultMessage() : " + error.getDefaultMessage());
            System.out.println("error.getCode() : " + error.getCode());
        });
        ErrorResponse errorR = ErrorResponse.builder()
                .message(errorMessage.toString())
                .reason(errorReason.toString())
                .build();

        ErrorResponse errorResponse = ErrorResponse.builder()
                .message("잘못된요청 " + ex.getBindingResult().getFieldError().getField().toString())
                .reason(("유효성 검사 실패 ")+ex.getBindingResult().getFieldError().getDefaultMessage())
                .build();
        return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(errorMessages);
    }
}

package com.ea.restapi05.exception;

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
import java.util.logging.FileHandler;
import java.util.stream.Collectors;

@ControllerAdvice
public class GlobalExceptionHandler extends ResponseEntityExceptionHandler {
    @Override
    protected ResponseEntity<Object>
        handleMethodArgumentNotValid(MethodArgumentNotValidException ex
                                    , HttpHeaders headers
                                    , HttpStatusCode status
                                    , WebRequest request) {

        List<FieldError> list = ex.getBindingResult().getFieldErrors();

        List<String> errorMassage = ex.getBindingResult()
                                        .getFieldErrors()
                                        .stream()
                                        .map(error -> error.getField() + " : " + error.getCode())
                                        .collect(Collectors.toList());

        List<String> errorReason = ex.getBindingResult()
                                        .getFieldErrors()
                                        .stream()
                                        .map(error -> error.getDefaultMessage())
                                        .collect(Collectors.toList());

        ErrorResponse response
                = ErrorResponse.builder()
                                .message(errorMassage.toString())
                                .reason(errorReason.toString())
                                .build();

        return ResponseEntity
                .status(HttpStatus.BAD_REQUEST)
                .body(response);
    }
}

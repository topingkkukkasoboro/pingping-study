package com.ea.restapi05.jwt;

import lombok.Data;

@Data
public class TokenDTO {
    private String email;
    private String password;
}
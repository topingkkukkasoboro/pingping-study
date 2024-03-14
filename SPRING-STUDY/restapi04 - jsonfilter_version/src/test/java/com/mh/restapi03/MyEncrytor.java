package com.mh.restapi03;

import org.jasypt.encryption.pbe.PooledPBEBigDecimalEncryptor;
import org.jasypt.encryption.pbe.PooledPBEStringEncryptor;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Value;

public class MyEncrytor {


    private String password="passw@rdpassw@rdpassw@rdpassw@rdpassw@rdpassw@rdpassw@rdpassw@rdpassw@rdpassw@rdpassw@rdpassw@rdpassw@rd";
    @Test
    void name() {
        System.out.println("실행됩니다.");
        System.out.println(password);

        PooledPBEStringEncryptor encryptor = new PooledPBEStringEncryptor();
        encryptor.setPoolSize(4);
        encryptor.setPassword(password);
        encryptor.setAlgorithm("PBEWithMD5ANdTripleDES");
        String content = "root";
        String encString = encryptor.encrypt(content);
        String decString = encryptor.decrypt(encString);
        System.out.println(String.format("root encString = %s decString = %s", encString, decString));
    }
}

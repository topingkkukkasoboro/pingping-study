package org.example.astact;

import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.Around;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Pointcut;

import javax.annotation.processing.ProcessingEnvironment;
import java.time.LocalTime;

@Aspect
public class Timeaspect {

    @Pointcut("excution( public * org..*(..))")
    private void publicTarget(){}

    @Around("publicTarget()")
    public Object measure(ProceedingJoinPoint proceedingJoinPoint) throws Throwable {
        LocalTime beforetime = LocalTime.now();
                try{
                    System.out.println("실행되니");
                    Object result = proceedingJoinPoint.proceed();
                    return result;
                }finally{

                }
    }
}

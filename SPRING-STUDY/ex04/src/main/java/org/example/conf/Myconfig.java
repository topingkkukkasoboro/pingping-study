package org.example.conf;

import org.apache.commons.dbcp2.BasicDataSource;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.mybatis.spring.SqlSessionFactoryBean;
import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.io.support.PathMatchingResourcePatternResolver;

import javax.sql.DataSource;

@Configuration
@ComponentScan("org.example.component")
public class Myconfig {

    @Autowired
    ApplicationContext  applicationContext;
@Bean(destroyMethod = "close")
    public DataSource dataSource(){

    BasicDataSource bds = new BasicDataSource();
    bds.setDriverClassName("com.mysql.cj.jdbc.Driver");
    bds.setUrl("jdbc:mysql://192.168.0.38/PMH");
    bds.setUsername("pmh");
    bds.setPassword("1234");
    return bds;
}
@Bean
    public SqlSessionFactory sqlSessionFactoryBean() throws Exception {
    SqlSessionFactoryBean  sqlSessionFactoryBean = new SqlSessionFactoryBean();
    sqlSessionFactoryBean.setDataSource(dataSource());
    sqlSessionFactoryBean.setMapperLocations(
            new PathMatchingResourcePatternResolver().getResources("classpath*:sql/*.xml"));
            return sqlSessionFactoryBean.getObject();
}

@Bean
    public SqlSession sqlSession() throws Exception{
    return new SqlSessionTemplate(sqlSessionFactoryBean());
}
}

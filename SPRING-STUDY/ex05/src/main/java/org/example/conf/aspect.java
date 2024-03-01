package org.example.conf;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.ComponentScans;
import org.springframework.context.annotation.Configuration;

@Configuration
@ComponentScan({"org.example.aspect", "org.example.components"})
public class aspect {
}

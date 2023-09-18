package com.spader.SeleniumCawlZerochanImageJava.Data;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.edge.EdgeDriver;

import java.util.concurrent.TimeUnit;

public class Login {
    Login() {
        WebDriver driver = new EdgeDriver();
        driver.get("https://www.zerochan.net/login");

        WebElement login = driver.findElement(By.name("name"));
        WebElement password = driver.findElement(By.name("password"));
        WebElement button = driver.findElement(By.name("login"));

        login.sendKeys("hieu555x");
        password.sendKeys("Trung_hieu9@");
        button.click();

        driver.manage().timeouts().implicitlyWait(20, TimeUnit.SECONDS);
    }
}

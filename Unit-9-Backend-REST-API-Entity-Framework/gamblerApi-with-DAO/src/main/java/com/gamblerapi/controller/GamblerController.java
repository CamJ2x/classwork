package com.gamblerapi.controller;
import com.gamblerapi.dao.GamblerDAO.GamblerMemoryDao;
import com.gamblerapi.model.Gambler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class GamblerController {

    public GamblerMemoryDao gamblerDao;
    @GetMapping("/")

    public String uniquecode1() {
        return "Welcome to Gambler API";
    }
}
@GetMapping("/gamblers")
public List<Gambler> getAllGamblers() {


}

package com.spader.SeleniumCawlZerochanImageJava.Controller;

import com.beust.ah.A;
import com.github.dockerjava.api.model.Links;
import com.spader.SeleniumCawlZerochanImageJava.Data.FindLink;
import com.spader.SeleniumCawlZerochanImageJava.Model.Link;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.ArrayList;
import java.util.List;

@RestController
public class LinkController {
    private ArrayList<Link> links = new ArrayList<Link>();

    @GetMapping("/links")
    public List<Link> getAll(@RequestParam(name = "links") String link) {
        String url = link;

        FindLink f = new FindLink();
        try {
            ArrayList<String> listLinks = new ArrayList<>();
            f.Login();
            int page = f.getPageIndex(url + "?s=id");

            for (int i = 0; i < page - 1; i++) {
                listLinks = f.getAllImageLink(url + "?s=id&p=" + (i + 1));
                for (String s : listLinks) {
                    String[] extractLink = s.split("/");
                    links.add(new Link(extractLink[extractLink.length - 1], s));
                }
            }
        } catch (Exception ex) {

        }
        f.quitChrome();
        return links;
    }

    @GetMapping("/")
    public String testSever(){
        return "Test suspect";
    }

    public void addLink() {
        String url = "https://www.zerochan.net/Kamisato+Ayaka";

        FindLink f = new FindLink();
        try {
            ArrayList<String> listLinks = new ArrayList<>();
            f.Login();
            int page = f.getPageIndex(url + "?s=id");
            for (int i = 0; i < page - 1; i++) {
                listLinks = f.getAllImageLink(url + "?s=id&p=" + (i + 1));
                for (String s : listLinks) {
                    links.add(new Link("1", s));
                }
            }
        } catch (Exception ex) {

        }
    }
}

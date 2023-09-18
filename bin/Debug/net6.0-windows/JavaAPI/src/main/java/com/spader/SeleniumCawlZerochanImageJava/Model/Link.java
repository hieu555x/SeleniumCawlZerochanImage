package com.spader.SeleniumCawlZerochanImageJava.Model;

public class Link {
    private String fileName;
    private String urlFile;

    public Link(String fileName,String urlFile){
        this.fileName = fileName;
        this.urlFile = urlFile;
    }

    public String getFileName() {
        return fileName;
    }

    public void setFileName(String fileName) {
        this.fileName = fileName;
    }

    public String getUrlFile() {
        return urlFile;
    }

    public void setUrlFile(String urlFile) {
        this.urlFile = urlFile;
    }
}

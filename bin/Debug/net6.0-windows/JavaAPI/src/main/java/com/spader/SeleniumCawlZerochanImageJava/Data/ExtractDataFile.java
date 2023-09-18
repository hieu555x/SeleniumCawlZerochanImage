package com.spader.SeleniumCawlZerochanImageJava.Data;

import java.io.*;

public class ExtractDataFile {
    String url;
    String finalPath;
    ExtractDataFile(String currentPath) throws FileNotFoundException {
        String line, finalLine = "";

        File file = new File(currentPath);
        BufferedReader reader = new BufferedReader(new FileReader(file));

        try {
            line = reader.readLine();
            while (line != null) {
                System.out.println(line);
                finalLine = finalLine + line;
                line = reader.readLine();
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        }

        url = finalLine.split("@ThisIsTheSpace@")[0];
        finalPath = finalLine.split("@ThisIsTheSpace@")[1];
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getFinalPath() {
        return finalPath;
    }

    public void setFinalPath(String finalPath) {
        this.finalPath = finalPath;
    }
}

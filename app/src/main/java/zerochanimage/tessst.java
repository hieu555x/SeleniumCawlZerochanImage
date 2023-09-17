package zerochanimage;

import java.io.*;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

public class tessst {
    public static void main(String[] args) throws FileNotFoundException {

        String line, finalLine = "";
        String currentPath = System.getProperty("user.dir") + "\\Input.txt";
        ExtractDataFile e = new ExtractDataFile(currentPath);

        System.out.println(e.getUrl());
        System.out.println(e.getFinalPath().replace("\\","\\\\"));
    }
}

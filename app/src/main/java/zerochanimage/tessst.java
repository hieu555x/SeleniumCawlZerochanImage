package zerochanimage;

import java.io.File;
import java.util.ArrayList;

public class tessst {
    public static void main(String[] args) {
        File f = new File("E:\\Picture\\MyWaifu");
        String[] childPath = f.list();
        for (int i = 0; i < childPath.length; i++) {
            System.out.println(childPath[i]);
        }
    }
}

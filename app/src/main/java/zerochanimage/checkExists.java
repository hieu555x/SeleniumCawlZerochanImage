package zerochanimage;

import java.io.File;

public class checkExists {
    public checkExists() {
    }

    public boolean check(String folderPath, String fileName) {
        File f = new File(folderPath);
        String[] childPath = f.list();
        for (String value : childPath) {
            String s = folderPath + "\\" + value;
            File child = new File(s);
            if (child.isDirectory()) {
                if (check(s, fileName)) {
                    return true;
                }
            } else {
                if (fileName.equals(value)) {
                    return true;
                }
            }
        }
        return false;
    }
}

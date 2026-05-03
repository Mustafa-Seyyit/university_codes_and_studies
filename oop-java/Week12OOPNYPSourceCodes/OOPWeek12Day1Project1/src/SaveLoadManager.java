import java.io.*;

public class SaveLoadManager {

    public static void WriteToFile(Object object, String filePath)  {

        try{
            FileOutputStream fileOutputStream = new FileOutputStream(filePath);
            ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
            objectOutputStream.writeObject(object);
        }
        catch (Exception e){

        }
    }

    public static Object ReadFromFile(String filePath){
        try{
            FileInputStream fileinputStream = new FileInputStream(filePath);
            ObjectInputStream objectInputStream = new ObjectInputStream(fileinputStream);
            return objectInputStream.readObject();
        }
        catch (Exception e){

        }
        return null;
    }
}

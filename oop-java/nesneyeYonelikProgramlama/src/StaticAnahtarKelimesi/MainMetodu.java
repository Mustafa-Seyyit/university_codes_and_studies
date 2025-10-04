package StaticAnahtarKelimesi;

public class MainMetodu {
    public static void main(String[] args){
        System.out.println(Kisiler.sayi);
        Kisiler k1 = new Kisiler("Mustafa Seyyit Dogan",28,"erkek");
        Kisiler k2 = new Kisiler("Fatmanur Dogan",28,"kız");
        Kisiler k3 = new Kisiler("Alperen Dogan",2,"erkek");
        System.out.println(Kisiler.sayi);
    }

}

package StaticAnahtarKelimesi;

public class Kisiler {
    public static int sayi = 0;
    private String adSoyad;
    private int yas;
    private String cinsiyet;

    public Kisiler(String adSoyad, int yas, String cinsiyet){
        this.adSoyad = adSoyad;
        this.yas = yas;
        this.cinsiyet = cinsiyet;
        sayi++;
    }
}

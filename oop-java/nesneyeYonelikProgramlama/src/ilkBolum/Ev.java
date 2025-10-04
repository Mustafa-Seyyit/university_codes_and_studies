package ilkBolum;

public class Ev {
    private void kasa(){//private metod tanımlama
        System.out.println("gizli kasa");

    }
    private String belge ="gizli belge";

    public static void main(String[] args) {
        /*
        Ev anne = new Ev();//ev sınıfından nesne oluşturuldu
        anne.kasa();//anne nesnensi kasaya ulaşmaya çalışıyor
        System.out.println(anne.belge);

         */
    }
    protected void bilgisayar() // protected metod tanimlandı
    {
        System.out.println("bilgisayar metodu");
    }
    protected String fatura ="Faturalar";//protected degisken tanimlandi
}

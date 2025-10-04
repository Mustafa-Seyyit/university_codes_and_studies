package Record;

import java.util.Objects;

public class Kisi {
    private String ad;
    private String soyad;
    private int yas;

    public Kisi(String ad, String soyad, int yas){
        this.ad = ad;
        this.soyad = soyad;
        this.yas = yas;
    }

    @Override
    public int hashCode(){
        return Objects.hash(ad,soyad,yas);
    }

    @Override
    public String toString(){
        return "Kisi [ad="+ad+", soyad="+soyad+"]";
    }

    @Override
    public boolean equals(Object obj){
        if (this == obj){
            return true;
        } else if (!(obj instanceof Kisi)) {
            return false;
        }else{
            Kisi kisi = (Kisi) obj;
            return Objects.equals(ad, kisi.ad) && Objects.equals(soyad, kisi.soyad);
        }
    }

    public String getAd(){
        return ad;
    }
    public String getSoyad(){
        return soyad;
    }

    public int getYas(){
        return yas;
    }
}

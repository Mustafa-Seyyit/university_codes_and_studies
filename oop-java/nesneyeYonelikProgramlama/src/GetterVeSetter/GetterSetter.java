package GetterVeSetter;

public class GetterSetter {
    /*
    private  String ad;
    private  int deger;

    public void setAd(String ad){
        this.ad = ad;
    }

    public String getAd(){
        return ad;
    }

    public void setDeger(int deger){
        this.deger = deger;
    }

    public int getDeger(){
        return deger;
    }

    public static void main(String[] args){
        GetterSetter nesne1 = new GetterSetter();
        nesne1.setAd("Mehmet");
        System.out.println(nesne1.getAd());
        nesne1.setDeger(5);
        System.out.println(nesne1.getDeger());
    }

     */
    private String ad;
    private int deger;

    public int getDeger() {
        return deger;
    }

    public String getAd(){
        return ad;
    }

    public GetterSetter(String ad, int deger){
        this.ad = ad;
        this.deger = deger;
        System.out.println(ad);
        System.out.println(deger);
    }

    public static void main(String[] args){
        GetterSetter n1 = new GetterSetter("mustafa",8);
    }
}


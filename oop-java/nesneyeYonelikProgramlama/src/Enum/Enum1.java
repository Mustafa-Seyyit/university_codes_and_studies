package Enum;

enum Maaslar{
    Ali(30000),Mehmet(40000),Mustafa(50000);
    public int maas;
    Maaslar(int maas){
        this.maas = maas;
    }

    int MaasGoster(){
        return maas;
    }
}

public class Enum1 {
    public static void main(String[] args){
        System.out.println(Maaslar.Ali.MaasGoster());
        System.out.println(Maaslar.Mehmet.MaasGoster());
        System.out.println(Maaslar.Mustafa.MaasGoster());
    }
}

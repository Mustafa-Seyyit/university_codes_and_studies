public class Main {
    public static void main(String[] args) {
        CanonBasic basic = new CanonBasic();
        CanonProfessional canonProfessional = new CanonProfessional();
        CanonOffice canonOffice = new CanonOffice();

        Printer[] printers = {basic, canonOffice, canonProfessional};

        for (Printer printer : printers)
            if(printer instanceof ScanBehaviour){
                ((FaxBehaviour)printer).fax();
            }
    }
}
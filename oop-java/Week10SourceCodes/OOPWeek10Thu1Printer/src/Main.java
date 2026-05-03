public class Main {
    public static void main(String[] args) {

        Printer basic = new CanonBasicPrinter();
        Printer prof = new CanonProfessionalPrinter();
        Printer off = new CanonOfficePrinter();

        Printer[] printers = {basic, prof,off};

        for(Printer printer : printers)
            if (printer instanceof FaxBehaviour)  // is
                ((ColorPrintBehaviour)printer).colorPrint();
    }
}
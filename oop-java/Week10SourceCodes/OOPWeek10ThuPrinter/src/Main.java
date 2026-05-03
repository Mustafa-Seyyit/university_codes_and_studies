public class Main {
    public static void main(String[] args) {
       Printer cbp = new CanonBasicPrinter();
       Printer cop = new CanonOfficePrinter();
       Printer cpp = new CanonProfessionalPrinter();

       Printer[] printers = {cpp, cop, cbp};

       for(Printer printer : printers)
           if (printer instanceof FaxBehaviour)
               ((ColorPrintBehaviour) printer).colorPrint();

    }
}
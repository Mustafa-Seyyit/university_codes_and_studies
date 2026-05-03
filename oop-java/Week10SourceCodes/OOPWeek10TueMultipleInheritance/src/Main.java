public class Main {
    public static void main(String[] args) {
       Printer printer1 = new CanonBasicPrinter();
       Printer printer2  = new CanonProfessionalPrinter();
       Printer printer3= new CanonOfficePrinter();

        if(printer3 instanceof ColorPrintBehaviours)
        ((ColorPrintBehaviours)printer3).colorPrint();

      // Printer[] printers = {printer1, printer2 ,printer3};


       //for(Printer printer: printers)
       //    if(printer instanceof FaxBehaviours)
        //       ((FaxBehaviours)printer).fax();
    }
}
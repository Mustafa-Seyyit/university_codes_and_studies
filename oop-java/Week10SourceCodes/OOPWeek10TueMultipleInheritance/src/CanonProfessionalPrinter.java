public class CanonProfessionalPrinter extends Printer implements ScanBehaviours, ColorPrintBehaviours, FaxBehaviours{
    @Override
    public void colorPrint() {
        System.out.println("CanonProfessionalPrinter color print");
    }

    @Override
    public void fax() {
        System.out.println("CanonProfessionalPrinter  fax");
    }

    @Override
    public void scan() {
        System.out.println("CanonProfessionalPrinter  scan");
    }

    @Override
    void print() {
        System.out.println("CanonProfessionalPrinter  print");
    }
}

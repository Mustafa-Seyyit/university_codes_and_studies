public class CanonProfessionalPrinter extends Printer implements ScanBehaviour, FaxBehaviour, ColorPrintBehaviour{
    @Override
    void print() {
        System.out.println("CanonProfessionalPrinter prints");
    }

    @Override
    public void fax() {
        System.out.println("CanonProfessionalPrinter faxes");
    }

    @Override
    public void scan() {
        System.out.println("CanonProfessionalPrinter scans");
    }

    @Override
    public void colorPrint() {
        System.out.println("CanonProfessionalPrinter colorPrints");
    }
}

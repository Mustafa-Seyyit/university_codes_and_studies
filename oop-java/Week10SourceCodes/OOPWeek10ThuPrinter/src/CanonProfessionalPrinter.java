public class CanonProfessionalPrinter extends Printer implements ColorPrintBehaviour, ScanBehaviour, FaxBehaviour{
    @Override
    void print() {
        System.out.println("CanonProfessionalPrinter prints");
    }

    @Override
    public void scan() {
        System.out.println("CanonProfessionalPrinter scans");
    }

    @Override
    public void fax() {
        System.out.println("CanonProfessionalPrinter faxes");
    }

    @Override
    public void colorPrint() {
        System.out.println("CanonProfessionalPrinter color prints");
    }
}

public class CanonOfficePrinter extends Printer implements FaxBehaviour, ScanBehaviour{

    @Override
    void print() {
        System.out.println("CanonOfficePrinter prints");
    }

    @Override
    public void scan() {
        System.out.println("CanonOfficePrinter scans");
    }

    @Override
    public void fax() {
        System.out.println("CanonOfficePrinter faxes");
    }
}

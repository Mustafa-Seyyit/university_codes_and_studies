public class CanonOffice extends Printer implements FaxBehaviour, ScanBehaviour{

    @Override
    public void fax() {
        System.out.println("CanonOffice faxes");
    }

    @Override
    public void scan() {
        System.out.println("CanonOffice scans");
    }

    @Override
    void print() {
        System.out.println("CanonOffice prints");
    }
}

public class CanonProfessional extends Printer implements ColoredPrintBehaviour, ScanBehaviour, FaxBehaviour{
    @Override
    void print() {
        System.out.println("CanonProfessional prints");
    }

    @Override
    public void colorPrint() {
        System.out.println("CanonProfessional colorPrints");
    }

    @Override
    public void scan() {
        System.out.println("CanonProfessional scans");
    }

    @Override
    public void fax() {
        System.out.println("CanonProfessional faxes");
    }
}

public class CanonOfficePrinter extends Printer implements FaxBehaviours, ScanBehaviours{
    @Override
    public void fax() {
        System.out.println("CanonOffice  fax");
    }

    @Override
    public void scan() {
        System.out.println("CanonOffice  scan");
    }

    @Override
    void print() {
        System.out.println("CanonOffice  print");
    }
}

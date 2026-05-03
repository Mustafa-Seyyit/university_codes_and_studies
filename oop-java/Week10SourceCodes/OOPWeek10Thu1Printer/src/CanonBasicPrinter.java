public class CanonBasicPrinter extends Printer implements ScanBehaviour{

    @Override
    void print() {
        System.out.println("CanonBasicPrinter prints");
    }

    @Override
    public void scan() {
        System.out.println("CanonBasicPrinter scans");
    }
}

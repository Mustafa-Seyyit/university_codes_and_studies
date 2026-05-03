public class CanonBasic extends Printer implements ScanBehaviour{

    @Override
    void print() {
        System.out.println("CanonBasic prints");
    }

    @Override
    public void scan() {
        System.out.println("CanonBasic scans");
    }
}

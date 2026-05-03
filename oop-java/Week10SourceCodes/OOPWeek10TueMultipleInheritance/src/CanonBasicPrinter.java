public class CanonBasicPrinter extends Printer implements ScanBehaviours{
    @Override
    public void scan() {
        System.out.println("CanonBasicPrinter  scan");
    }

    @Override
    void print() {
        System.out.println("CanonBasicPrinter  print");
    }
}

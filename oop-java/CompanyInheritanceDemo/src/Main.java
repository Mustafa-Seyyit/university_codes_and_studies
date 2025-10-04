public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("      Inheritance and Overriding Demo    ");
        System.out.println("=========================================");

        // Creating objects of different types
        Company defaultCompany = new Company();
        AkinSoft akinSoft = new AkinSoft();
        GoogleCompany googleCompany = new GoogleCompany();

        // 1. Base Class (Company) Demonstration
        System.out.println("\n--- 1. Base Company ---");
        System.out.println("Address: " + defaultCompany.getAddress()); // Calls Company.getAddress()
        defaultCompany.print();                                        // Calls Company.print()

        // 2. GoogleCompany Demonstration (Shows ALL Overriding)
        System.out.println("\n--- 2. Google Company ---");
        System.out.println("Address: " + googleCompany.getAddress()); // Calls GoogleCompany.getAddress()
        googleCompany.print();                                         // Calls GoogleCompany.print()
        googleCompany.doSomething();                                   // Calls GoogleCompany.doSomething() (Unique method)

        // 3. AkinSoft Demonstration (Shows Partial Overriding)
        System.out.println("\n--- 3. AkinSoft ---");
        System.out.println("Address: " + akinSoft.getAddress()); // Calls AkinSoft.getAddress()
        akinSoft.print();                                         // Inherits and calls Company.print()
    }
}
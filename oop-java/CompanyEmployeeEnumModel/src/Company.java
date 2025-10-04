public class Company {
    // Removed the confusing default employee assignment
    private Employee employee;
    private CompanyName companyName;

    public Company(Employee employee, CompanyName companyName) {
        this.employee = employee;
        this.companyName = companyName;
    }

    // --- Accessor (Getter) Methods ---

    public Employee getEmployee() {
        return employee;
    }

    public CompanyName getCompanyName() {
        return companyName;
    }

    // Displays the full relationship information
    public void displayCompanyInfo() {
        System.out.println("Company: " + companyName.name());
        System.out.println("Sector: " + (companyName == CompanyName.AKINSOFT ? "Local Software" : "Global Tech"));
        System.out.println("Employed Worker: " + employee.toString());
    }
}
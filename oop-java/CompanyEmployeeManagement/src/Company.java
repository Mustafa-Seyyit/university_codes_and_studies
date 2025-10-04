import java.util.List;

public class Company {
    // Used List interface for better flexibility
    private final List<Employee> employees;
    private final CompanyName companyName;

    public Company(List<Employee> employees, CompanyName companyName) {
        this.employees = employees;
        this.companyName = companyName;
    }

    // --- Accessor (Getter) Methods ---

    public CompanyName getCompanyName() {
        return companyName;
    }

    public List<Employee> getEmployees() {
        return employees;
    }

    /** Provides a formatted string representation of the Company object. */
    @Override
    public String toString() {
        return "Company {" +
                "Name = " + companyName +
                ", Employees = " + employees.toString() +
                '}';
    }
}
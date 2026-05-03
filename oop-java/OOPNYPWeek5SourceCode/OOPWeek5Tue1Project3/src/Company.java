
enum CompanyName{
    APPLE,
    MICROSOFT,
    GOOGLE,
    IBM;
}
public class Company {
    private Employee[] employees;
    private CompanyName companyName;

    Company(Employee[] emps, CompanyName c){
        this.employees = emps;
        this.companyName = c;
    }

    public Employee[] getEmployees(){
        return employees;
    }

    public CompanyName getCompanyName() {
        return companyName;
    }
}


enum CompanyName{
    APPLE, GOOGLE, MICROSOFT, IBM;
}
public class Company {
    private Employee[] employees;
    private CompanyName companyName;

    public Company(Employee[] es, CompanyName cn){
        this.employees = es;
        this.companyName = cn;
    }

    public Employee[] getEmployees(){
        return employees;
    }

    public CompanyName getCompanyName() {
        return companyName;
    }
}




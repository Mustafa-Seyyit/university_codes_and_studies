public abstract class Employee {
    String fName;
    String lName;
    int ssn;

    Employee(String fName, String lName, int ssn)
    {
        this.fName = fName;
        this.lName = lName;
        this.ssn = ssn;
    }

    abstract double earning();

    @Override
    public String toString() {
        return String.format("FName: %s LName: %s SSN: %d", fName,lName,ssn);
    }
}

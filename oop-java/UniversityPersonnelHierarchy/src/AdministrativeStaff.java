public class AdministrativeStaff extends Employee {
    private String officeDepartment; // departman
    private int overtimeHours; // mesai

    public AdministrativeStaff(String fullName, String email, String phone, String officeDepartment, int overtimeHours) {
        super(fullName, email, phone);
        this.officeDepartment = officeDepartment;
        this.overtimeHours = overtimeHours;
    }

    public void work() {
        System.out.println(super.getFullName() + " is working in the " + this.officeDepartment + " department.");
    }
}
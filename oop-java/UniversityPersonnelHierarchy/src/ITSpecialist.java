public class ITSpecialist extends AdministrativeStaff {
    private String ITTask; // gorev

    public ITSpecialist(String fullName, String email, String phone, String officeDepartment, int overtimeHours, String ITTask) {
        super(fullName, email, phone, officeDepartment, overtimeHours);
        this.ITTask = ITTask;
    }

    public void performMaintenance() { // tarama
        System.out.println(super.getFullName() + " is performing system maintenance: " + this.ITTask);
    }
}
public class SecurityGuard extends AdministrativeStaff {
    private String certificationLevel; // belge

    public SecurityGuard(String fullName, String email, String phone, String officeDepartment, int overtimeHours, String certificationLevel) {
        super(fullName, email, phone, officeDepartment, overtimeHours);
        this.certificationLevel = certificationLevel;
    }

    public void patrol() { // nobet
        System.out.println(super.getFullName() + " is on patrol duty (Cert: " + this.certificationLevel + ").");
    }
}
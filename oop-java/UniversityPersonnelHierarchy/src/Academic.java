public class Academic extends Employee {
    private String department;
    private String title;
    private String[] coursesTaught;

    public Academic(String fullName, String email, String phone, String department, String title, String[] coursesTaught) {
        super(fullName, email, phone);
        this.department = department;
        this.title = title;
        this.coursesTaught = coursesTaught;
    }

    public void enterClass() {
        System.out.println(super.getFullName() + " entered the class.");
    }
}
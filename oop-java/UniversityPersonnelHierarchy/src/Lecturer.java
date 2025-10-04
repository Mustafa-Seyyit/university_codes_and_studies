public class Lecturer extends Academic {
    private String academicRank; // unvan

    public Lecturer(String fullName, String email, String phone, String department, String title, String[] coursesTaught, String academicRank) {
        super(fullName, email, phone, department, title, coursesTaught);
        this.academicRank = academicRank;
    }

    public void attendMeeting() {
        System.out.println(super.getFullName() + " attended the meeting.");
    }

    public void gradeExams() {
        System.out.println(super.getFullName() + " graded the exams.");
    }
}
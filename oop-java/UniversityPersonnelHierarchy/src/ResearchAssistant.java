public class ResearchAssistant extends Academic {
    private String thesisStatus; // yuksekLisans

    public ResearchAssistant(String fullName, String email, String phone, String department, String title, String[] coursesTaught, String thesisStatus) {
        super(fullName, email, phone, department, title, coursesTaught);
        this.thesisStatus = thesisStatus;
    }

    public void enterLab() {
        System.out.println(super.getFullName() + " entered the lab.");
    }

    public void gradeQuizzes() {
        System.out.println(super.getFullName() + " graded the quizzes.");
    }
}
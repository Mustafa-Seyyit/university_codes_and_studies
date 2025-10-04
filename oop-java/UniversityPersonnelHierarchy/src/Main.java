public class Main {
    public static void main(String[] args) {

        System.out.println("=============================================");
        System.out.println("  University Personnel Hierarchy Showcase    ");
        System.out.println("=============================================");

        // 1. Employee (Base Class Demo)
        Employee baseEmployee = new Employee("Ahmet Yılmaz", "ay@uni.edu", "555-1000");
        baseEmployee.checkIn();
        baseEmployee.eatLunch();
        System.out.println("---------------------------------------------");

        // 2. Lecturer (Academic Sub-Class Demo)
        String[] lecturerCourses = {"Java OOP", "Software Arch."};
        Lecturer lecturer = new Lecturer(
                "Dr. Emre Can", "emre@uni.edu", "555-2000",
                "Computer Science", "Assoc. Prof.", lecturerCourses, "Senior Lecturer"
        );

        lecturer.checkIn();      // Inherited from Employee
        lecturer.enterClass();    // Inherited from Academic
        lecturer.gradeExams();    // Unique to Lecturer
        System.out.println("---------------------------------------------");

        // 3. Research Assistant (Academic Sub-Class Demo)
        ResearchAssistant assistant = new ResearchAssistant(
                "Zeynep Kaya", "zk@uni.edu", "555-3000",
                "Electrical Eng.", "Research Fellow", new String[]{"Signals"}, "Thesis in Progress"
        );

        assistant.checkIn();      // Inherited from Employee
        assistant.enterLab();     // Unique to ResearchAssistant
        assistant.gradeQuizzes();
        System.out.println("---------------------------------------------");

        // 4. IT Specialist (Administrative Sub-Class Demo)
        ITSpecialist itStaff = new ITSpecialist(
                "Murat Akın", "ma@uni.edu", "555-4000",
                "IT Support", 5, "Network Diagnostics"
        );

        itStaff.checkIn();      // Inherited from Employee
        itStaff.work();         // Inherited from AdministrativeStaff
        itStaff.performMaintenance(); // Unique to ITSpecialist
        System.out.println("---------------------------------------------");

        // 5. Security Guard (Administrative Sub-Class Demo)
        SecurityGuard guard = new SecurityGuard(
                "Deniz Demir", "dd@uni.edu", "555-5000",
                "Security", 10, "Level 3"
        );
        guard.patrol();
        guard.checkOut(); // Inherited from Employee
    }
}
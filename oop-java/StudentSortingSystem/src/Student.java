// Student class implements Comparable for natural ordering (based on grade)
class Student implements Comparable<Student> {
    // Variable names are already English and follow convention
    int rollNumber;
    String name;
    int age;
    int grade;

    // Constructor
    public Student(int rollNumber, String name, int age, int grade) {
        this.rollNumber = rollNumber;
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    // compareTo method: Sorts by grade in ascending order
    @Override
    public int compareTo(Student otherStudent) {
        // Using Integer.compare for clearer and safer comparison
        return Integer.compare(this.grade, otherStudent.grade);
    }

    // toString method: Provides a formatted string representation of the object
    @Override
    public String toString() {
        return rollNumber + " " + name + " " + age + " Grade: " + grade;
    }
}

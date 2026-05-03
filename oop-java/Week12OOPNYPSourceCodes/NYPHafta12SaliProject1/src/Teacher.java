enum Branch{
    MATH, PHYSICS, CS
}
public class Teacher implements Comparable<Teacher>{
    String name;
    Branch branch;
    int id;
    double wage;


    public Teacher(String name, int id, double wage, Branch branch) {
        this.name = name;
        this.id = id;
        this.wage = wage;
        this.branch = branch;
    }

    @Override
    public boolean equals(Object otherObject) {

        if(this == otherObject) return true;
        else if(otherObject == null || this.getClass() != otherObject.getClass()) return  false;
        else {
            Teacher otherTeacher = (Teacher) otherObject;
            return this.name.equals(otherTeacher.name) &&
                    this.id == otherTeacher.id &&
                    this.wage == otherTeacher.wage &&
                    this.branch.equals(otherTeacher.branch);
        }
    }


    @Override
    public int compareTo(Teacher other) {
        //return this.name.compareTo(other.name);
        //return this.id -other.id;
        if(this.id > other.id) return  1;
        else if(this.id < other.id) return -1;
        else return 0;
    }

    @Override
    public String toString() {
        return String.format("Name %s ID:%d Wage: %.2f Branch: %s",name,id,wage,branch);
    }
}

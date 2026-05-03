public class Student {
    String name;
    float mid;
    float fin;

    float computeStudentScore(){
        float score = mid*0.4f +fin*0.6f;
        return score;
    }
}

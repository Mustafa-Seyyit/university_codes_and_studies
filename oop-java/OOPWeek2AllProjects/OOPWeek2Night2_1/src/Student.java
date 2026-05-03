public class Student {
    String name;
    float midTerm;
    float finScore;


    float computeScore(){
        return 0.4f * midTerm + 0.6f*finScore;
    }
}

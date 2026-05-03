public class Student {
    String name;
    float mid;
    float fin;

    void showScoreAndName(){
        float score =  mid*0.4f + fin *0.6f;
        System.out.printf("name: %s  score: %f  %n", name, score);
    }
}

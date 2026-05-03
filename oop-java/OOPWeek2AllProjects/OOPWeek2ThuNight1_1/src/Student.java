 class Student {
    String name;
    float midScore;
    float finScore;

    float computeScore(){
        return midScore*0.4f + finScore * 0.6f;
    }

    String returnInfo()
    {
        return  name + " "+midScore + " "+ finScore;
    }
}

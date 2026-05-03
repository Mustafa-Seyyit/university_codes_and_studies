
enum Branch{
    MATH(1, "this extremely useful course"),
    PHSICS(2),
    CS(5);

    private int id;
    String description;
     Branch(int id, String description){
        this.id = id;
        this.description = description;
    }

     Branch(int id){
        this.id = id;
    }


    public int getId() {
        return id;
    }
}


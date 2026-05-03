public class Rectangle {
    int x;
    int y;
    float width;
    float height;

    // create unit square in origin
    Rectangle(){
//        this.x = 0;
//        this.y = 0;
//        this.width =1;
//        this.height =1;
        this(1,1);
    }

    // create custom rectangle in origin
    Rectangle(float width, float height){
//        this.x = 0;
//        this.y = 0;
//        this.width =width;
//        this.height =height;
        this(0,0,width,height);
    }


    // create custom rectangle in custom locations
    public Rectangle(int x, int y, float width, float height){
        this.x = x;
        this.y = y;
        this.width =width;
        this.height =height;
    }
}

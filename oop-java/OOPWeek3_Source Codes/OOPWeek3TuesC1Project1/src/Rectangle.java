public class Rectangle {
    float x;
    float y;
   private float width;
   private float height;

    //create unit quad at origin  x=0, y= 0, widht=1, height=1;
    Rectangle(){
        this(0,0,1,1);
    }

    //create a rectangle at origin  x=0, y= 0, widht= userVal, height= userVal;
    Rectangle(float w, float h){
//        this.x = 0;
//        this.y = 0;
//        this.width =w;
//        this.height =h;
        this(0, 0, w, h);
    }

    //create a rectangle at anywhere  x=userV, y= userV, widht= userVal, height= userVal;
     Rectangle(float x, float y, float w, float h){
        this.x = x;
        this.y = y;
        this.width =w;
        this.height =h;
    }
}

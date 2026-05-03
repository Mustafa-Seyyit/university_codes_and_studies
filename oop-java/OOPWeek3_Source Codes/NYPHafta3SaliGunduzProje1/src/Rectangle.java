public class Rectangle {

    int x = 0;
    int y = 0;

    float width =1;
    float height=1;


    public Rectangle(){  // orijinde birim kare
//        this.x = 0;
//        this.y = 0;
//        this.width = 1;
//        this.height =1;
        this(1,1);
    }

    public Rectangle(float w, float h){  // orijinde w ve h değeri girilen dikdörtgen
//        this.x = 0;
//        this.y = 0;
//        this.width = w;
//        this.height =h;
        this(0,0,w,h);
    }

    public Rectangle(int x, int y, float w, float h){  // bir x ve y noktasında w ve h değeri girilen dikdörtgen
        this.x = x;
        this.y = y;
        this.width = w;
        this.height =h;
    }


    void showRectangleInfo(){
        System.out.printf(" x: %d y: %d w: %.2f h: %.2f %n", x,y,width,height);
    }
}

public class Rectangle {

    int x;
    int y;

    float width;
    float height;


    public Rectangle()  // birim kare orijinde
    {
//        this.x = 0;
//        this.y = 0;
//        this.width = 1;
//        this.height =1;

        this(1,1);
    }

    public Rectangle(float width, float height)  // boyutlarını kullanıcının girdiği dikdörtgen orijinde
    {
//        this.x = 0;
//        this.y = 0;
//        this.width = width;
//        this.height =height;
        this(0,0,width,height);
    }

    public Rectangle(int x, int y, float width, float height)  // boyutlarını kullanıcının girdiği dikdörtgen ve herhange x y konumu
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height =height;
    }
}

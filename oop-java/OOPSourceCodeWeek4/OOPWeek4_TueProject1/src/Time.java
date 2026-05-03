public class Time {

    private int hour;
    private int minute;
    private int second;

    Time(int hour, int minute, int second){
       try{
           setHour(hour);
           setMinute(minute);
           setSecond(second);
       }catch (Exception e){
           System.out.println(e.getMessage());
       }
    }

    public void setHour(int hour) throws Exception{
        if(hour < 0 || hour > 23)
            throw  new IllegalArgumentException("please enter a valid hour value");
        this.hour = hour;
    }

    public void setMinute(int minute) throws Exception{
        if(minute < 0 || minute > 59)
            throw  new IllegalArgumentException("please enter a valid minute value");
        this.minute = minute;
    }

    public void setSecond(int second) throws Exception{
        if(second < 0 || second > 59)
            throw  new IllegalArgumentException("please enter a valid second value");
        this.second = second;
    }
    //AM PM format
    public String toString(){
        return String.format("%d : %d  : %d : %s",
                (this.hour > 12) ? (this.hour-12): this.hour,
                this.minute,
                this.second,
                (this.hour > 12) ? "PM": "AM");
    }

    public String toUniversalString(){
        return String.format("%d : %d  : %d",
                this.hour,
                this.minute,
                this.second);
    }
}

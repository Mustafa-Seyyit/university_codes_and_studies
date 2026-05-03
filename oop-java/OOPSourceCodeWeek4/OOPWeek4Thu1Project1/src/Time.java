public class Time {

    private int hour;
    private int minute;
    private int second;

    Time(int hour, int minute, int second){
       try{
           setHour(hour);
       }catch (Exception e){
           System.out.println(e.getMessage());
       }

        try{
            setMinute(minute);
        }catch (Exception e){
            System.out.println(e.getMessage());
        }

        try{
            setSecond(second);
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
    }

    public void setHour(int hour) throws Exception{
        if (hour< 0 || hour> 23)
            throw new IllegalArgumentException("hour value must be between 0 and 23");
        this.hour = hour;
    }

    public void setMinute(int minute)throws Exception{
        if (minute< 0 || minute> 59)
            throw new IllegalArgumentException("minute value must be between 0 and 59");
        this.minute = minute;
    }

    public void setSecond(int second)throws Exception{
        if (second< 0 || second> 59)
            throw new IllegalArgumentException("second value must be between 0 and 59");
        this.second = second;
    }

    public String toShortString(){
        return String.format("%d : %d : %d : %s",
                (this.hour>12) ?this.hour-12: this.hour,
                this.minute,
                this.second,
                this.hour<12? "AM":"PM"
                );
    }

    public String toUniversalString(){
        return String.format("%d: %d :%d",this.hour, this.minute, this.second);
    }


}

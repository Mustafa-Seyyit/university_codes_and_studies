public class Time {
    // Encapsulation: Fields are private
    private int hour;
    private int minute;
    private int second;

    /** Constructor: Initializes Time with hour, minute, and second */
    public Time(int hour, int minute, int second) {
        // Delegate initial setting to the setTime method for validation
        setTime(hour, minute, second);
    }

    // Default constructor for convenience
    public Time() {
        this(0, 0, 0);
    }

    /**
     * Sets a new time value, validating the inputs.
     * Throws an IllegalArgumentException if values are invalid.
     */
    public void setTime(int hour, int minute, int second) {
        if (hour < 0 || hour >= 24 || minute < 0 || minute >= 60 || second < 0 || second >= 60) {
            throw new IllegalArgumentException("Time values must be valid: hour (0-23), minute (0-59), second (0-59).");
        }
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    // --- Mutator (Setter) Methods ---

    public void setHour(int hour) {
        // Delegates validation to setTime, keeping other parts of time constant
        setTime(hour, this.minute, this.second);
    }

    public void setMinute(int minute) {
        // Delegates validation to setTime, keeping other parts of time constant
        setTime(this.hour, minute, this.second);
    }

    public void setSecond(int second) {
        // Delegates validation to setTime, keeping other parts of time constant
        setTime(this.hour, this.minute, second);
    }

    // --- Accessor (Getter) Methods ---

    public int getHour() {
        return hour;
    }

    public int getMinute() {
        return minute;
    }

    public int getSecond() {
        return second;
    }

    // --- Display Methods ---

    /** Returns the time in Universal (24-hour) format (HH:MM:SS). */
    public String toUniversalString() {
        return String.format("%02d:%02d:%02d", hour, minute, second);
    }

    /** Overrides Object.toString(). Returns the time in standard (12-hour) format (H:MM:SS AM/PM). */
    @Override
    public String toString() {
        return String.format("%d:%02d:%02d %s",
                ((hour == 0 || hour == 12) ? 12 : hour % 12), // Converts 0 and 12-23 to 12 or 1-11
                minute,
                second,
                (hour < 12 ? "AM" : "PM"));
    }
}
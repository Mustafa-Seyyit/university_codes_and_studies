public class Post {
    // Corrected spelling and standardized naming
    private String message;
    private String sourceAddress;
    private String targetAddress;

    public Post(String message, String sourceAddress, String targetAddress) {
        this.message = message;
        this.sourceAddress = sourceAddress;
        this.targetAddress = targetAddress;
    }

    // --- Accessor (Getter) Methods for Encapsulation ---

    public String getMessage() {
        return message;
    }

    public String getSourceAddress() {
        return sourceAddress;
    }

    public String getTargetAddress() {
        return targetAddress;
    }
}
public class PostOffice {
    private String name;

    public PostOffice(String name) {
        this.name = name;
    }

    /** Simulates sending the post, displaying the sender's details. */
    public void postSend(Post post) {
        System.out.println("----------------------------------------");
        System.out.println("Message SENT by Post Office: " + name);
        System.out.println("Message Content: " + post.getMessage());
        System.out.println("Source Address: " + post.getSourceAddress());
        System.out.println("Target Address: " + post.getTargetAddress());
        System.out.println("----------------------------------------");
    }

    /** Simulates receiving the post, displaying the receiver's details. */
    public void postReceive(Post post) {
        System.out.println("Message RECEIVED by Post Office: " + name);
        System.out.println("Message Content: " + post.getMessage());
        System.out.println("Source Address: " + post.getSourceAddress());
        System.out.println("Target Address: " + post.getTargetAddress());
        System.out.println("----------------------------------------\n");
    }
}
public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("      Mail Transfer Simulator            ");
        System.out.println("=========================================");

        // 1. Initialize two post offices
        PostOffice po1 = new PostOffice("PTT Mail");
        PostOffice po2 = new PostOffice("MNG Delivery");

        // 2. Create a Post/Message object
        Post post = new Post(
                "Greetings! My name is Azrael, and this is a demonstration message.",
                "Heaven",
                "Your Soul"
        );

        // 3. Simulate the transfer process
        po1.postSend(post);

        // Simulate a delay/transit period...

        po2.postReceive(post);

        // Example of a second post
        Post post2 = new Post(
                "Your package has arrived.",
                "Amazon Warehouse",
                "Home Address"
        );

        System.out.println("\n--- Second Delivery Demo ---");
        po2.postSend(post2);
        po1.postReceive(post2);
    }
}
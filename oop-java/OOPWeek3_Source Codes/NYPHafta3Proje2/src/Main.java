public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        Account account = new Account("my account",100);
        System.out.println(account.getBalance());

        //account.setName("not my account");
    }
}
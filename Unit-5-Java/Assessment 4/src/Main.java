import co.grandcircus.co.grandcircus.Account;

public class Main {
    public static void main(String[] args) {
        Account account = new Account(112233, "julia");
        account.addTransaction("", "Deposit", 1000.00);
        account.addTransaction("Target", "Payment", 50.00);
        account.addTransaction("", "Withdrawal", 60.00);
        account.addTransaction("Target", "Payment", 75.00);
        account.addTransaction("", "Withdrawal", 200.00);
        account.addTransaction("Amazon", "Payment", 50.00);
        account.addTransaction("", "Deposit", 150.00);

        System.out.println("Welcome " + account.getName() + ", Account Number: " + account.getAccountNumber());
        System.out.println("Current Balance: ");
        System.out.println(String.format("%.2f", account.findCurrentBalance()));
        System.out.println("Largest Transaction: ");
        System.out.println(String.format("%.2f", account.findLargestTransactionForPayee("Target")));



    }
}
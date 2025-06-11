package co.grandcircus;

public class Transaction {
    // the private variables
    private String payee;
    private String transactionType;
    private double amount;
    // Getters for all
    public String getPayee() {
        return payee;
    }

    public String getTransactionType() {
        return transactionType;
    }

    public double getAmount() {
        return amount;
    }
    // Public constructor that takes in all variables
    public Transaction(String payee, String transactionType, double amount) {
        this.payee = payee;
        this.transactionType = transactionType;
        this.amount = amount;
    }

}

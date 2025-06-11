package co.grandcircus.co.grandcircus;

import co.grandcircus.Transaction;

import java.util.ArrayList;

public class Account {
    // three private variables
    private int accountNumber;
    private String name;
    private ArrayList<Transaction> transactions;
    // getters and setters for accountNumber and name

    public int getAccountNumber() {
        return accountNumber;
    }

    public void setAccountNumber(int accountNumber) {
        this.accountNumber = accountNumber;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    // Create a constructor that takes an accountNumber and name,
    // and initializes accountNumber and name appropriately
    public Account(int accountNumber, String name) {
        this.accountNumber = accountNumber;
        this.name = name;
        this.transactions = new ArrayList<>();
    }
    // Create a method called addTransaction that takes three members
    public void addTransaction(String payee, String transactionType, double amount){
        Transaction transaction = new Transaction(payee, transactionType, amount);
        this.transactions.add(transaction);
    }
    //Create a method called findLargestTransactionForPayee that takes a single parameter,
    // payee (String) and returns double. Search through the list of transactions,
    // and locate the largest transaction for that particular payee,
    // and return that transaction’s value.
    public double findLargestTransactionForPayee(String payee) {
        double transactionValue = 0;
        for(Transaction transaction : transactions) {
            if(transaction.getPayee().equals(payee)) {
                if(transaction.getAmount() > transactionValue) {
                    transactionValue = transaction.getAmount();
                }
            }

        }
        return transactionValue;
    }
    //Create a method called findCurrentBalance that takes no parameters
    // and returns a double. This method loops through the transactions
    // and determines the current balance.
    public double findCurrentBalance() {
        double balance = 0.0;
        for(Transaction transaction : transactions) {
            String transactionType = transaction.getTransactionType();
            double amount = transaction.getAmount();
            if( transactionType.equals("Deposit")){
                balance += amount;
            } else if ( transactionType.equals("Payment") || transactionType.equals("Withdrawal")) {
                balance -= amount;
            }
        }
        return balance;
    }
}

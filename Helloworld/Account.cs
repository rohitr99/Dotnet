namespace banking;
 public class Account{
    private float balance;

    public Account(){
        this.balance=100000;
    }
    public Account(float balance){
        this.balance=balance;
    }
     public void Setbalance(float b){
        this.balance=b;
     }
     public float getbalance(){
        return balance;
     }

     public void withdrail(float amount){
        if(amount==0){
           throw new Exception ("balance amount is zero");
        }
        else{
        balance-=amount;
        }

     }

     public void deposit(float amount){
        balance+=amount;
     }


 }

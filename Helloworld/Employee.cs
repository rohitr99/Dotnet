namespace hr;
public class Employee{
    private int id{
        get;set;
    }
    private String firstname{
        get;set;
    }
    private String lastname{
        get;set;
    }

    public Employee():this(1,"xyz","abc"){
        
    }
    public Employee(int id,String firstname,String lastname){
        this.firstname=firstname;
        this.id=id;
        this.lastname=lastname;
    }
    // public abstract float ComputePay();
    public virtual float ComputePay(){
        return 56000;
    }



    public override string ToString()
    {
        return id+" "+firstname+" "+lastname;
    }

}
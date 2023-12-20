namespace hr;
public class SalesEmp:WageEmp{
    public float target{
        get;set;
    }
    public float incentive{
        get;set;
    }
    public static int count;
    public SalesEmp():this(10,"rohit","shende",8,700000,50000){
        count ++;

    }
    public SalesEmp(int id, String firstname,String lastname,int workinghour,float target,float incentive):base(id,firstname,lastname,workinghour){
        this.target=target;
        this.incentive=incentive;
    }
    public override float ComputePay(){
        if(target>800000){
            float totalsal=base.ComputePay()+incentive;
            return totalsal;
        }
        else{
            float totalsal=base.ComputePay();
            return totalsal;
        }
    }
    public string ToString(){
        return base.ToString()+"Target: "+ this.target + " Incentive: "+ this.incentive;
    }
    ~ SalesEmp(){
        count--;
    }
}
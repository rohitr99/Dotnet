namespace hr;
public class WageEmp:Employee{
    private int workinghour{
        get;set;
    }
    public WageEmp():this(12,"saleer","dfg",10){

    }
    public WageEmp(int id,String firstname,String lastname,int workinghour):base(id,firstname,lastname){
        this.workinghour=workinghour;
    }
    public override float ComputePay()
    {
        return base.ComputePay()+workinghour*500;
    }
       // public override float ComputePay()
    // {
    //     return workinghour*500;
    // }
    public override string ToString()
    {
        return base.ToString()+"Working hour "+workinghour;
    }
}
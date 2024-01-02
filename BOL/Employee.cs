namespace EmployeePortal.BOL;
public class Employee
{

    public Employee(int id, string name, int salary, string gender)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
        this.Gender = gender;
    }

    public int Id
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    public int Salary
    {
        get; set;
    }
    public string? Gender
    {
        get; set;
    }
}
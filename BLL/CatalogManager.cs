using DAL.Connected;
using EmployeePortal.BOL;

namespace BLL;


public static class CatalogManager
{

    public static List<Employee> GetEmployees()
    {
        List<Employee> employees = DBManager.GetEmployees();
        return employees;
    }

    public static bool InsertEmployee(int id, string name, int salary, string gender)
    {
        return DBManager.InsertEmployee(id, name, salary, gender);
    }

    public static Employee GetEmployeeById(int id)
    {
        return DBManager.GetEmployeeById(id);
    }

    public static bool EditEmployeeDetails(int id, string name, int salary, string gender)
    {
        return DBManager.EditEmployeeDetails(id, name, salary, gender);
    }

}
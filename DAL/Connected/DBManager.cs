namespace DAL.Connected;
using EmployeePortal.BOL;
using MySql.Data.MySqlClient;
public static class DBManager
{
    public static string constring = "server=localhost;port=3306;user=root;password=welcome;database=ecommerce";


    public static List<Employee> GetEmployees()
    {
        List<Employee> elist = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = constring;
        string query = "select * from employee";

        MySqlCommand cmd = new MySqlCommand(query, con);

        try
        {
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string? name = reader["name"].ToString();
                int salary = int.Parse(reader["salary"].ToString());
                string? gender = reader["gender"].ToString();
                Employee e = new Employee(id, name, salary, gender);
                elist.Add(e);
            }
            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }

        return elist;
    }

    public static bool InsertEmployee(int id, string name, int salary, string gender)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = constring;
        string query = "insert into employee values(@id,@name,@salary,@gender)";

        try
        {
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@gender", gender);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            return false;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return false;
    }

    public static Employee GetEmployeeById(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = constring;
        string query = "select * from employee where id=@id";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = int.Parse(reader["id"].ToString());
                string? Name = reader["name"].ToString();
                int Salary = int.Parse(reader["salary"].ToString());
                string? Gender = reader["gender"].ToString();

                Employee e = new Employee(Id, Name, Salary, Gender);
                return e;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return null;
    }

    public static bool EditEmployeeDetails(int id, string name, int salary, string gender)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = constring;
        string query = "update employee set name=@name, salary=@salary, gender=@gender where id=@id";
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@gender", gender);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return false;
    }

}
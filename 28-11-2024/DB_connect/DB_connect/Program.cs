using System.Data.SqlClient;

public class test
{
    public static void Main(string[] args)
    {
        string connectionstring = "Data Source=PREETHU_GSS\\MSSQLSERVER02;Initial Catalog=SchoolDB;Integrated Security=True";
        string query = "select * from student";
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["studentID"] + " " + reader["studentName"] + " " + reader["studentAdress"]);
            }
            connection.Close();
        }
    }
}
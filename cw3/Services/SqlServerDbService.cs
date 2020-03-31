using System.Collections.Generic;
using System.Data.SqlClient;
using cw3.Models;

namespace cw3.Services
{
    public class SqlServerDbService: IStudentsDbService
    {
        string SqlConnection = "Data Source=db-mssql;Initial Catalog=s18693;Integrated Security=True";

        public void AddStudnet(string INumber, string FName, string LName, string BDate, string Studies)
        {
            using (var client = new SqlConnection(SqlConnection))
            using (var command = new SqlCommand())
            {
                command.Connection = client;
                command.CommandText = "findStudiesN";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", Studies);

                client.Open();
                var dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Student s = new Student { IndexNumber = INumber, FirstName = FName, LastName = LName, BirthDate = BDate, IdEnrollment = int.Parse(dr["id"].ToString()) };
                }

            }
        }

        public IEnumerable<Student> GetStudents()
        {
            var StudentList = new List<Student>();

            using (var client = new SqlConnection(SqlConnection))
            using (var command = new SqlCommand())
            {
                command.Connection = client;
                command.CommandText = "";

            }
                return null;
        }
    }
}

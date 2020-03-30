using System.Collections.Generic;
using System.Data.SqlClient;
using cw3.Models;

namespace cw3.Services
{
    public class StudentDbService: IStudentsDbService
    {
        string SqlConnection = "Data Source=db-mssql;Initial Catalog=s18693;Integrated Security=True";

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

using System.Collections.Generic;
using cw3.Models;

namespace cw3.Services
{
    public interface IStudentsDbService
    {
        public IEnumerable<Student> GetStudents();

        public void AddStudnet(string IndexNumber, string FirstName, string LastName, string BirthDate, string Studies);
    }
}

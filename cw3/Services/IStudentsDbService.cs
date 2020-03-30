using System.Collections.Generic;
using cw3.Models;

namespace cw3.Services
{
    public interface IStudentsDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}

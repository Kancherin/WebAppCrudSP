using System.Collections.Generic;
using WebAppCrudSP.Web.Models;

namespace WebAppCrudSP.Web.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents(string name);
        void SaveOrUpdate(Student student);
        void Delete(int id);
    }
}

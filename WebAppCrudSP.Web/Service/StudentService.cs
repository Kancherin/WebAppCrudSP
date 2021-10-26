using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCrudSP.Web.Context;
using WebAppCrudSP.Web.Models;

namespace WebAppCrudSP.Web.Service
{
    public class StudentService : IStudentService
    {
        DatabaseContext _databaseContext = null;

        public StudentService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void Delete(int id)
        {
            _databaseContext.Database.ExecuteSqlRaw($"DeleteStudent {id}");
            //Test
            var students = _databaseContext.Students.ToList();
        }

        public List<Student> GetStudents(string name)
        {
            var students = _databaseContext.Students.FromSqlRaw($"GetStudents {name}").ToList();
            return students;
        }

        public void SaveOrUpdate(Student student)
        {
            _databaseContext.Database.ExecuteSqlRaw($"SaveOrUpdateStudent {student.Id}, {student.Nombre}, {student.Edad}");

            //Test
            var students = _databaseContext.Students.ToList();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCrudSP.Web.Models;
using WebAppCrudSP.Web.Service;

namespace WebAppCrudSP.Web.Controllers
{
    public class StudentsController : Controller
    {
        IStudentService _studentService = null;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<Student> GetStudents(string name)
        {
            return _studentService.GetStudents(name);
        }

        public void SaveOrUpdate(Student student)
        {
            _studentService.SaveOrUpdate(student);
        }

        public void Delete(int id)
        {
            _studentService.Delete(id);
        }
    }
}

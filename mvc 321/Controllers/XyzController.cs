using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_321.Models;
using mvc_321.ViewModels;

namespace mvc_321.Controllers
{
    public class XyzController : Controller
    {
        //
        // GET: /Xyz/
        public ActionResult Abc()
        {
            course math = new course();
            math.CourseName = "math";
            math.TotalCredits = 4;
            
            List<student> students=new List<student>();
            student alex = new student();
            alex.FirstName = "Alex";
            alex.Lastname = "Eod";
            student john = new student();
            john.FirstName = "john";
            john.Lastname = "123";
            student kk = new student();
           kk.FirstName = "kk";
           kk.Lastname = "123";
        
students.Add(kk);
students.Add(alex);
students.Add(john);
            
                course_student obj = new course_student();
            obj.course = math;
            obj.students = students;
           // return "from xyz controller abc action";
            return View(obj);
        }
        public ActionResult index()
        {
            return View();
        }
        public ActionResult matchlist()
        {
            return View();
        }
        public ActionResult userlist()
        {
            return View();
        }
	}
}
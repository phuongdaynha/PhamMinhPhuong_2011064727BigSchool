using PhamMinhPhuong_2011064727lab3.Models;
using PhamMinhPhuong_2011064727lab3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhamMinhPhuong_2011064727lab3.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        public CoursesController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbcontext.categories.ToList()

            };
            return View(viewModel);
        }
    }
}
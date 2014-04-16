using ExamReviewProject.Data;
using ExamReviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamReviewProject.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult Index()
        {
            GetJobsFromVM()

            return View(model);
        }
    }
}
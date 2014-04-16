using ExamReviewProject.Adapters.DBAdapters;
using ExamReviewProject.Adapters.Interfaces;
using ExamReviewProject.Data;
using ExamReviewProject.DataModels;
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
        IJobs _adapter;
        public JobController () {
            _adapter = new JobsDBAdapter();
        }
        
        ViewModelVehicle model = new ViewModelVehicle();

        // GET: Job
        public ActionResult Index()
        {
            model = _adapter.GetJobsFromVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string newJobTitle, double newSalary, int newCompanyId, Company newCompany)
        {
            model = _adapter.PostJob(newJobTitle, newSalary, newCompanyId);
            model.Jobs = _adapter.GetJobsFromVM().Jobs.ToList();
            return View(model);
        }

    }
}
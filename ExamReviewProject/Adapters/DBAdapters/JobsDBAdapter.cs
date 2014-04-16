using ExamReviewProject.Adapters.Interfaces;
using ExamReviewProject.Data;
using ExamReviewProject.DataModels;
using ExamReviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamReviewProject.Adapters.DBAdapters
{
    public class JobsDBAdapter : IJobs
    {
        public ViewModelVehicle GetJobsFromVM()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            ViewModelVehicle model = new ViewModelVehicle();

            model.Jobs = db.Jobs.ToList();

            return model;
        }


        public ViewModelVehicle PostJob(string newJobTitle, double newSalary, int newCompanyId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            ViewModelVehicle model = new ViewModelVehicle();

            model.Job = new Job();
            model.Job.JobTitle = newJobTitle;
            model.Job.Salary = newSalary;
            model.Job.CompanyId = newCompanyId;

            db.Jobs.Add(model.Job);
            db.SaveChanges();
            
            return model;
        }
    }
}
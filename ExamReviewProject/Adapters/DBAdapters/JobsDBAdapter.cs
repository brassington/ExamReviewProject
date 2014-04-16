using ExamReviewProject.Adapters.Interfaces;
using ExamReviewProject.Data;
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
    }
}
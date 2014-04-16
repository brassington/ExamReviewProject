using ExamReviewProject.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamReviewProject.Models
{
    public class ViewModelVehicle
    {
        public List<Job> Jobs { get; set; }
        public List<Company> Companies { get; set; }
    }
}
using ExamReviewProject.DataModels;
using ExamReviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamReviewProject.Adapters.Interfaces
{
    public interface IJobs
    {
        ViewModelVehicle GetJobsFromVM();
        ViewModelVehicle PostJob(string newJobTitle, double newSalary, int newCompanyId);
    }
}

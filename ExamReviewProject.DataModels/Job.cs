using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamReviewProject.DataModels
{
    public class Job
    {
        //PK
        public int Id { get; set; }

        public string JobTitle { get; set; }
        public double Salary { get; set; }

        //FK
        public int CompanyId { get; set; }
    }
}

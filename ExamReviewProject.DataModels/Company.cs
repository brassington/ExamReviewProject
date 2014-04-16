using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamReviewProject.DataModels
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public virtual List<Job> Jobs { get; set; }
    }
}

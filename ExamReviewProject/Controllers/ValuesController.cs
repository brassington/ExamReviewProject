using ExamReviewProject.Adapters.DBAdapters;
using ExamReviewProject.Adapters.Interfaces;
using ExamReviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExamReviewProject.Controllers
{
    public class ValuesController : ApiController
    {
        IJobs _adapter;
        public ValuesController()
        {
            _adapter = new JobsDBAdapter();
        }
        
        ViewModelVehicle model = new ViewModelVehicle();

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            model = _adapter.GetJobsFromVM();
            if (model != null)
            {
                return Ok(model.Jobs);
            }

            return NotFound();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
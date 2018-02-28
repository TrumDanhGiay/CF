using CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CF.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public void Get()
        {
            using(var DbContext = new StudentCOntext())
            {
                Student student = DbContext.Student.FirstOrDefault();
                student.name = "Duong Trang";
                DbContext.ChangeTracker.DetectChanges();
                DbContext.SaveChanges();
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

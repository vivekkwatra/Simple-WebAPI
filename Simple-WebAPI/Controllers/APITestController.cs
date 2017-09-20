using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Simple_WebAPI.Controllers
{
    //DbContext.StudentEntities studentEntities = new DbContext.StudentEntities();

    public class APITestController : ApiController
    {
        // GET: APITest
        public IHttpActionResult GetStudents()
        {
            //var query = studentEntities.StudentMasters.ToList();
            var query = "Hello";

            return Ok(query);
        }
    }
}
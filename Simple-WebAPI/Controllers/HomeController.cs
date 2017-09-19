using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace Simple_WebAPI.Controllers
{
    //DbContext.StudentEntities studentEntities = new DbContext.StudentEntities();

    public class HomeController : ApiController
    {
        public IHttpActionResult GetStudents()
        {
            //var query = studentEntities.StudentMasters.ToList();
            var query = "Hello";

            return Ok(query);
        }
    }
}

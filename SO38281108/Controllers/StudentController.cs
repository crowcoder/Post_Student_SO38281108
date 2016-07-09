using SO38281108.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SO38281108.Controllers
{
    public class StudentController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post([FromBody] Student student)
        {
            if (student == null) return BadRequest();
            
            return CreatedAtRoute("StudentApi", new { ID = student.ID }, student);
        }
    }
}

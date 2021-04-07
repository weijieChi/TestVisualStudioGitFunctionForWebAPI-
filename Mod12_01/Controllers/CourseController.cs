using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mod12_01.Models;

namespace Mod12_01.Controllers
{
    public class CourseController : ApiController
    {

        private static List<Course> courses = new List<Course>
        {
            new Course{Id = 1, Name = "MVC"},
            new Course{Id = 2, Name = "WebForm"},
            new Course{Id = 3, Name = "WebAPI"}
        };
        
        // GET: api/Course
        public IEnumerable<Course> Get()
        {
            return courses;
        }

        // GET: api/Course/5
        public Course Get(int id)
        {
            var course = courses.Find(c => c.Id == id);
            return course;
        }

        // POST: api/Course
        public void Post([FromBody]Course course)
        {
            courses.Add(course);
        }

        // PUT: api/Course/5
        public void Put(int id, [FromBody]Course course)
        {
            var item = courses.Find(c => c.Id == id);
            item.Name = course.Name;
        }

        // DELETE: api/Course/5
        public void Delete(int id)
        {
            var course = courses.Find(c => c.Id == id);
            courses.Remove(course);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo1.Models;

namespace Demo1.Controllers
{
    public class EmployController : ApiController
    {
        Employ[] arrEmploy = new Employ[]
        {
            new Employ{Empno=1,Name="Arun",
                Dept="Dotnet",Desig="Developer",
                Basic=88234},
            new Employ{Empno=2,Name="Jitu",
                Dept="Dotnet",Desig="WebDev",
                Basic=85664},
            new Employ{Empno=3,Name="Anusha",
                Dept="SQL",Desig="Developer",
                Basic=85433},
            new Employ{Empno=4,Name="Dhivya",
                Dept="Dotnet",Desig="Expert",
                Basic=73224},
            new Employ{Empno=5,Name="Suhaas",
                Dept="Java",Desig="Developer",
                Basic=74332},
        };

        //This Method will return all the Employees in Employ array
        public IEnumerable<Employ> Get()
        {
            return arrEmploy;
            // http://localhost:58006/api/Employ
        }

        //This Method will return the employ based on Employ id given
        public IHttpActionResult Get(int id)
        {
            var emp = arrEmploy.FirstOrDefault((e) => e.Empno == id);

            if (emp == null)
            {
                return NotFound();
            }

            return Ok(emp);
        }
    }
}

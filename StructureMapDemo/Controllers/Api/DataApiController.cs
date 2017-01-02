using System;
using System.Web.Http;
using Common;
using Resources;
using StructureMapDemo.Filters;
using StructureMapDemo.Services;

namespace StructureMapDemo.Controllers.Api
{
    public class DataApiController : ApiController
    {
        private readonly IWorker _worker;

        public DataApiController(IWorker worker)
        {
            _worker = worker;
        }
        
        [HttpGet]
        public Person GetPerson()
        {
            var building = new Building();
            return new Person { Name = strings.Name, Age = 28 };
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
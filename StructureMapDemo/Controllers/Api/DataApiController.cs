using System;
using System.Web.Http;
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
            throw new Exception("Test exception");
            return new Person { Name = "Ivan", Age = 28 };
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
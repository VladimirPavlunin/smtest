using System.Web.Http;

namespace StructureMapDemo.Controllers.Api
{
    public class DataApiController : ApiController
    {
        [HttpGet]
        public Person GetPerson()
        {
            return new Person { Name = "Ivan", Age = 28 };
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
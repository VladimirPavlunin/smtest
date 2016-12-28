using System.Web.Http.Filters;
using StructureMap.Attributes;
using StructureMapDemo.Services;

namespace StructureMapDemo.Filters
{
    public class ApiErrorFilterAttribute : ExceptionFilterAttribute
    {
        [SetterProperty]
        public IWorker Worker { get; set; }

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Worker.DoWork();
            base.OnException(actionExecutedContext);
        }
    }
}
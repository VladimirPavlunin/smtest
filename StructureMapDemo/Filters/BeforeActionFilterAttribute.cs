using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using StructureMap.Attributes;
using StructureMapDemo.Services;

namespace StructureMapDemo.Filters
{
    public class BeforeActionFilterAttribute : ActionFilterAttribute
    {
        [SetterProperty]
        public IWorker Worker { get; set; }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Worker.DoWork();
            base.OnActionExecuting(actionContext);
        }
    }
}
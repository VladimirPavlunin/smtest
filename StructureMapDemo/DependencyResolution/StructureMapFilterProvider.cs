using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using StructureMap;

namespace StructureMapDemo.DependencyResolution
{
    public class StructureMapFilterProvider : ActionDescriptorFilterProvider, IFilterProvider
    {
        private readonly IContainer _container;

        public StructureMapFilterProvider(IContainer container)
        {
            _container = container;
        }

        public new IEnumerable<FilterInfo> GetFilters(HttpConfiguration configuration, HttpActionDescriptor actionDescriptor)
        {
            var filters = base.GetFilters(configuration, actionDescriptor).ToList();

            var glogalFilters = GlobalConfiguration.Configuration.Filters;

            foreach (var filter in filters)
            {
                _container.BuildUp(filter.Instance);
            }

            foreach (var globalFilter in glogalFilters)
            {
                _container.BuildUp(globalFilter.Instance);
            }

            return filters;
        }
    }
}
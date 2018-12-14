using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using Swashbuckle.AspNetCore.Swagger;

namespace Swagger.OpenAPI.MultipleVersions.Filters
{
    public class RemoveVersionParameters : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            // Remove version parameter from all Operations
            var versionParameter = operation.Parameters.Single(p => p.Name == "version");
            operation.Parameters.Remove(versionParameter);
        }
    }
}

using Microsoft.AspNetCore.Mvc.Controllers;
using Swagger.OpenAPI.Attributes;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;
using System.Reflection;

namespace Swagger.OpenAPI.Filters
{
    /// <summary>
    /// 
    /// </summary>

    public class HideGetVerbInDocsFilter : IDocumentFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="context"></param>
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (var contextApiDescription in context.ApiDescriptions)
            {
                var actionDescriptor = (ControllerActionDescriptor)contextApiDescription.ActionDescriptor;
                var anyDesc = actionDescriptor.ControllerTypeInfo.GetCustomAttributes<HideInDocsAttribute>().Any() ||
                    actionDescriptor.MethodInfo.GetCustomAttributes<HideInDocsAttribute>().Any();
                if (!anyDesc)
                {
                    continue;
                }
                //else
                //{
                var key = "/" + contextApiDescription.RelativePath.TrimEnd('/');
                PathItem pathItem = null;
                try
                {
                    pathItem = swaggerDoc.Paths[key];
                }
                catch (Exception)
                {
                    pathItem = null;
                }
                if (pathItem == null)
                    continue;

                switch (contextApiDescription.HttpMethod.ToUpper())
                {
                    case "GET":
                        pathItem.Get = null;
                        break;
                    //case "POST":
                    //    pathItem.Post = null;
                    //    break;
                    //case "PUT":
                    //    pathItem.Put = null;
                    //    break;
                    //case "DELETE":
                    //    pathItem.Delete = null;
                    //    break;
                    default:
                        break;
                }

                if (pathItem.Get == null  // ignore other methods
                                          //&& pathItem.Post == null
                                          //&& pathItem.Put == null
                                          //&& pathItem.Delete == null
                    )
                    swaggerDoc.Paths.Remove(key);
                //}
            }
        }

    }
}

using System;

namespace Swagger.OpenAPI.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Parameter, AllowMultiple = true)]
    public class HideInDocsAttribute : Attribute
    { }
}

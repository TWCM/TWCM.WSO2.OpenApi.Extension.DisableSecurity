using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace TWCM.WSO2.OpenApi.Extension.DisableSecurity
{
    /// <summary>
    /// Wso2DisableSecurityOperationFilter
    /// </summary>
    public class Wso2DisableSecurityOperationFilter : IOperationFilter
    {
        /// <summary>
        /// Apply
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            var classAttributes = context.MethodInfo.DeclaringType!.GetCustomAttributes(true).OfType<Wso2DisableSecurityAttribute>();

            var methodAttributes = context.MethodInfo.GetCustomAttributes(true).OfType<Wso2DisableSecurityAttribute>();

            //class attribute will be ignored if method attribute exist
            if (methodAttributes.Any()) {

                operation.Extensions.Add("x-wso2-disable-security", new OpenApiBoolean(methodAttributes.First().IsEnable));


                return;
            }
            if (classAttributes.Any())
            {


                operation.Extensions.Add("x-wso2-disable-security", new OpenApiBoolean(classAttributes.First().IsEnable));


                return;
            }
        }
    }
}

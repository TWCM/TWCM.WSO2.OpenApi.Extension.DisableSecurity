using System;

namespace TWCM.WSO2.OpenApi.Extension.DisableSecurity
{

    /// <summary>
    /// Wso2DisableSecurityAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class Wso2DisableSecurityAttribute : Attribute
    {
        /// <summary>
        /// IsEnable
        /// </summary>
        public bool IsEnable { get; set; } = false;
        /// <summary>
        /// Wso2DisableSecurityAttribute
        /// </summary>
        /// <param name="isEnable"></param>
        public Wso2DisableSecurityAttribute(bool isEnable=false)
        {
            this.IsEnable = isEnable;

        }    
    }
}

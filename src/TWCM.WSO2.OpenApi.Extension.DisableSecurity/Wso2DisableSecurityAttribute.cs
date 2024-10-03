using System;

namespace TWCM.WSO2.OpenApi.Extension.DisableSecurity
{
  

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class Wso2DisableSecurityAttribute : Attribute
    {
        public bool IsEnable { get; set; } = false;
        public Wso2DisableSecurityAttribute(bool isEnable=false)
        {
            this.IsEnable = isEnable;

        }    
    }
}

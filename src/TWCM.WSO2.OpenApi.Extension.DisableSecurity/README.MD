# TWCM.WSO2.OpenApi.Extension.DisableSecurity
To add the x-wso2-disable-security to openapi document to disable the security in wso2

## How to use

### Add the attribute to method level or controller level in controller
```cs
   [Wso2DisableSecurity(true)]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
```

or 

```cs
        [Wso2DisableSecurity(false)]
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
```
### Add the Wso2DisableSecurityOperationFilter to swaggerGen in Program.cs or Startup.cs
```cs
builder.Services.AddSwaggerGen(c =>
{
    c.OperationFilter<Wso2DisableSecurityOperationFilter>();
});
```



### Reference
https://apim.docs.wso2.com/en/4.0.0/deploy-and-publish/deploy-on-gateway/choreo-connect/security/api-authentication/disabling-security/
# 


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


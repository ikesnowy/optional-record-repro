using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OptionalRecordTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("/GetQueryString")]
    public IActionResult GetQueryString([FromQuery] PagingParams? pagingParams = null)
    {
        return Ok(pagingParams);
    }
}
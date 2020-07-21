using Microsoft.AspNetCore.Mvc;

namespace Todo.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}

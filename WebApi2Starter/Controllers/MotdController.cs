namespace WebApi2Starter.Controllers
{
    using System.Web.Http;

    public class MotdController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Yo!");
        }
    }
}
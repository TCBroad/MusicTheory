namespace TheoryTest.Controllers.api
{
    using System.Web.Http;

    public class DefaultController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "hello";
        }
    }
}
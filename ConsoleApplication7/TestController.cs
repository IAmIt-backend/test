using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApplication7
{
    public class TestController : ApiController
    {
        private readonly IService _service;

        public TestController(IService service)
        {
            _service = service;
        }

		
		
		
        [HttpGet, Route("")]
        public IHttpActionResult Test() => Ok(_service.Foo);
    }
}

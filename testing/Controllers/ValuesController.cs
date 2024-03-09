using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.DAO;

namespace testing.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        MainDBcontext _context;

        public ValuesController(MainDBcontext context) {
            _context = context;
        }
    }
}

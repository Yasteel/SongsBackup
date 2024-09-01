using SongsBackup.Controllers.Api;

namespace SongsBackup.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    
    using SongsBackup.Interfaces;

    [Route("test")]
    public class TestController : ApiBaseController
    {
        [HttpGet("get")]
        public IActionResult TestGet()
        {
            return this.Ok();
        }        
        
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Legal_AI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleSignInController : ControllerBase
    {
        private object generatedJwtToken;

        [HttpPost]
        public IActionResult SignInWithGoogle([FromBody] GoogleSignInRequest request)
        {
              return Ok(new { token = generatedJwtToken });
        }
    }
    public class TokenRequest
    {
        public string Token { get; set; }
    }

    public class GoogleSignInRequest
    {
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestCICDInGitHubAction.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MathController : ControllerBase
{
    [HttpGet]
    public async Task<int> Calc()
    {
        return 5 + 8;
    }
}

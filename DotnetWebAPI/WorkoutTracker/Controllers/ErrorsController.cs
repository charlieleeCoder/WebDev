using Microsoft.AspNetCore.Mvc;

namespace WorkoutTracker.Controllers;

public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}

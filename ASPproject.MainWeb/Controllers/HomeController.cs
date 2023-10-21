using Microsoft.AspNetCore.Mvc;

namespace ASPproject.MainWeb.Controllers;

[Route("/api/home")]
public class HomeController : Controller {
    [HttpGet]
    public IActionResult Get() {
        var value = new { id = 1, items = 2 };
        return Ok(value);
    }
}

using ASPproject.Core;
using ASPproject.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPproject.MainWeb.Controllers;

[Route("/api/user")]
public class UserController : Controller {

    private readonly ProjDBContext context;

    public UserController(ProjDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IActionResult Get() {
        var list = context.Users.ToList();

        return Ok(list);
    }

    [HttpPost]
    public IActionResult Post([FromBody] User user) {
        context.Users.Add(user);
        context.SaveChanges();

        return Created("", user);
    }
}

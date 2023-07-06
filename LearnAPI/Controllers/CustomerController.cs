using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers;

public class CustomerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
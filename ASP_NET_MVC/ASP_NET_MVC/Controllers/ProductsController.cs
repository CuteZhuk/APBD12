using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_MVC.Controllers;

[Route("api/[controller]")]
public class ProductsController : Controller
{
    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        
    }
}
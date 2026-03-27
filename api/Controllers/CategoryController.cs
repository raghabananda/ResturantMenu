using Microsoft.AspNetCore.Mvc;
using api.Data;
using api.Models;

namespace api.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Category>> GetAll()
        => Ok(DataStore.Categories);
}

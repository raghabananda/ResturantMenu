using Microsoft.AspNetCore.Mvc;
using api.Data;
using api.Models;

namespace api.Controllers;

[ApiController]
[Route("api/menu")]
public class MenuController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<MenuItem>> GetAll()
        => Ok(DataStore.MenuItems);

    [HttpGet("{id:int}")]
    public ActionResult<MenuItem> GetById(int id)
    {
        var item = DataStore.MenuItems.FirstOrDefault(m => m.Id == id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpGet("category/{category}")]
    public ActionResult<IEnumerable<MenuItem>> GetByCategory(string category)
    {
        var items = DataStore.MenuItems
            .Where(m => m.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToList();
        return Ok(items);
    }

    [HttpGet("specials")]
    public ActionResult<IEnumerable<MenuItem>> GetSpecials()
        => Ok(DataStore.MenuItems.Where(m => m.IsChefSpecial));
}

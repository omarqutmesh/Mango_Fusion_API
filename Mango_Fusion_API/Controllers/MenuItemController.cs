using Mango_Fusion_API.Data;
using Mango_Fusion_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Mango_Fusion_API.Controllers
{
    [Route("api/MenuItem")]
    [ApiController]
    public class MenuItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ApiResponse _response;

        public MenuItemController(ApplicationDbContext db) 
        {
            _db = db;
            _response = new ApiResponse();
        }
        [HttpGet]
        public IActionResult GetMenuItem() 
        {
            _response.Result = _db.MenuItems.ToList();
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }
    }
}

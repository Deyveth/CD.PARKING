using CD.STORE.ApplicationService.Usm;
using CD.STORE.Entities.Usm;
using CD.STORE.IApplicationService.Usm;
using CD.STORE.Utility.Response;
using Microsoft.AspNetCore.Mvc;

namespace CD.STORE.Api.Controllers.Usm
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;
        private readonly IMenuService _menuService;

        public MenuController(ILogger<MenuController> logger, IMenuService menuService)
        {
            _logger = logger;
            _menuService = menuService;
        }

        [HttpGet("GetAllByUser/{userId}")]
        public ActionResult<CustomResponse<List<Menu>>> GetAllByUser(int userId)
        {
            try
            {
                List<Menu> menu = _menuService.GetAllByUser(userId);

                if (menu.Count() == 0)
                    return NoContent();

                CustomResponse<List<Menu>> result = new()
                {
                    Success = true,
                    Message = $"Se encontraron {menu.Count} registros",
                    Data = menu
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
        }

    }
}

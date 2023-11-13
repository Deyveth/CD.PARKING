using CD.STORE.ApplicationService.Usm;
using CD.STORE.Entities.Usm;
using CD.STORE.IApplicationService.Usm;
using CD.STORE.Utility.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CD.STORE.Api.Controllers.Usm
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ILogger<RoleController> _logger;
        private readonly IRoleService _roleService;

        public RoleController(ILogger<RoleController> logger, IRoleService roleService)
        {
            _logger = logger;
            _roleService = roleService;
        }

        [HttpGet]
        public ActionResult<string> GetAll()
        {
            try
            {
                List<Role> roles = _roleService.GetAll();

                if(roles == null)
                    return NoContent();

                CustomResponse<List<Role>> result = new()
                {
                    Success = true,
                    Message = $"Se encontraron {roles.Count} registros",
                    Data = roles
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
        }
        //[HttpGet("search")]
        //public async ValueTask<ActionResult<PaginatorResponse<UsuarioGetResponse>>> SearchPaginate([FromQuery] UsuarioQuery query)
        //{
        //    SearchPagResponse<UsuarioGetResponse> result = await _IUsuarioService.SearchPaginate(query);
        //    PaginatorResponse<UsuarioGetResponse> response = new()
        //    {
        //        Success = true,
        //        Message = $"Se encontraron {result.Data.Count()} registros.",
        //        TotalRecords = result.TotalRecords,
        //        Data = result.Data
        //    };
        //    return Ok(response);
        //}
    }
}

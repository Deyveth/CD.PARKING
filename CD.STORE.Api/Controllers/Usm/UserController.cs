using CD.STORE.Api.Models;
using CD.STORE.Entities.Usm;
using CD.STORE.IApplicationService.Usm;
using CD.STORE.Utility.Response;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CD.STORE.Api.Controllers.Usm
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetOne(int id)
        {
            try
            {
                User response = _userService.GetOne(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<CustomResponse<List<User>>> GetAll()
        {
            try
            {
                List<User> users = _userService.GetAllWithDetails();

                if (users == null)
                    return NoContent();

                CustomResponse<List<User>> result = new()
                {
                    Success = true,
                    Message = $"Se encontraron {users.Count} registros",
                    Data = users
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost]
        public ActionResult<CustomResponse<User>> Save(User item)
        {
            try
            {
                User user;
                var currentDate = DateTime.Now;
                user = new User
                {
                    RoleId = item.RoleId,
                    Username = item.Username,
                    Email = item.Email,
                    Password = item.Password,
                    IsActive = item.IsActive,
                    InsDate = currentDate,
                    UserInsId = 1,
                    UpdaDate = currentDate,
                    UserUpdaId = 1
                };

                _userService.Save(user);

                CustomResponse<User> response = new()
                {
                    Success = true,
                    Message = "Usuario creado correctamente",
                    Data = user
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut("{id}")]
        public ActionResult<CustomResponse<User>> UpdateUser(int id, User user)
        {
            try
            {
                User result = _userService.GetOne(id);

                if (user == null)
                    return NoContent();

                var currentDate = DateTime.Now;

                result.RoleId = user.RoleId;
                result.Username = user.Username;
                result.Email = user.Email;
                result.Password = user.Password;
                result.IsActive = user.IsActive;
                result.UserUpdaId = 1;
                result.UpdaDate = currentDate;

                _userService.Save(result);

                CustomResponse<User> response = new()
                {
                    Success = true,
                    Message = "Usuario actualizado correctamente",
                    Data = user
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<User> Login([FromBody] Login login)
        {
            try
            {

                User user = _userService.ValidateUser(login.Email, login.Password);

                if (user == null)
                    return NoContent();

                CustomResponse<User> response = new()
                {
                    Success = true,
                    Message = "Inicio de sesión con éxito",
                    Data = user
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<CustomResponse> DeleteUser(int id)
        {
            try
            {

                User user = _userService.GetOne(id);

                if (user == null)
                    return NoContent();

                User result = _userService.Delete(user);

                CustomResponse response = new()
                {
                    Success = true,
                    Message = "Se eliminó el usuario con éxito"
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
        }

    }
}


using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Request;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // criação de usuario(tipo post)
        [HttpPost]
        // vai retornar de resposta o ResponseRegisterUserJson com status 201 created
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            return Created();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        //https://docs.microsoft.com/pt-br/aspnet/core/security/authorization/roles?view=aspnetcore-2.1

        [Authorize("Bearer")]   //Policy, Roles
        [HttpGet]
        public object Get(int idProduto)
        {
            return new
            {
                Nome = "caderno",
                Valor = 10
            };
        }
    }
}
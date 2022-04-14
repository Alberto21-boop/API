using Microsoft.AspNetCore.Mvc;
using TreinamentoBack.Model;
using TreinamentoBack.Service;

namespace TreinamentoBack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : BaseController<Endereco, int>
    {
        public EnderecoController() : base(new EnderecoService())
        {

        }
    }
}

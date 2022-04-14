using Microsoft.AspNetCore.Mvc;
using TreinamentoBack.Model;
using TreinamentoBack.Service;


namespace TreinamentoBack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : BaseController<Pessoa, int>
    {
       
        public PessoaController() : base(new PessoaService())
        {
           
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TreinamentoBack.Model;
using TreinamentoBack.Service;


namespace TreinamentoBack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmpregoController : BaseController<Emprego, int>
    {
        public EmpregoController() : base(new EmpregoService())
        {

        }
    }
}

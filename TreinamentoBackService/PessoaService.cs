using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBack.DataBase;
using TreinamentoBack.Model;

namespace TreinamentoBack.Service
{
    public class PessoaService : BaseService<Pessoa>
    {
        public PessoaService() : base(new PessoaEntity())
        {

        }
    }
}

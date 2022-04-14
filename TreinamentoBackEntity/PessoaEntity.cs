using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBack.Model;

namespace TreinamentoBack.DataBase
{
    public class PessoaEntity : BaseEntity<Pessoa>
    {
        public PessoaEntity() : base()
        {

        }
    }
}

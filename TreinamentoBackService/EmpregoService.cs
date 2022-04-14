using TreinamentoBack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBack.DataBase;

namespace TreinamentoBack.Service
{
    public class EmpregoService : BaseService<Emprego>
    {
        public EmpregoService() : base(new EmpregoEntity())
        {

        }
    }
}

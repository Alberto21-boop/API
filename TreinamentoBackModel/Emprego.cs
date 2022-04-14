using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBack.Model
{
    public class Emprego : BaseModel<Emprego>
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; } = default!;

    }
}

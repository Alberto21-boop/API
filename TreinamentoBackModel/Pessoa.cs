using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBack.Model
{
    public class Pessoa : BaseModel<Pessoa>
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = default!;

        public int IdEmprego { get; set; }

        public int IdEbdereco { get; set; }

        public string Email { get; set; } = default!;

        public string TelefoneRecidencial { get; set; } = default!;

        public string TelefoneCelular { get; set; } = default!;

        public DateTime DataDeNascimento { get; set; }

    }
}

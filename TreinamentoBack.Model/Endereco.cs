using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBack.Model
{
    internal class Endereco : BaseModel<Endereco>
    {
        [Key]

        public int Id { get; set; }

        public string Logradouro { get; set; } = default!;

        public int Numero { get; set; }

        public string Complemento { get; set; } = default!;

        public string Estado { get; set; } = default!;

        public string Cidade { get; set; } = default!;

        public string CEP { get; set; } = default!;

    }
}

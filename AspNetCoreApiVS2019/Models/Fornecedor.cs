using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApiVS2019.Models
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} tem que ter entre {2} e {1} caracteres", MinimumLength =2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(17, ErrorMessage = "O campo {0} tem que ter entre {2} e {1} caracteres", MinimumLength = 13)]
        public string Documento { get; set; }

        public string TipoFornecedor { get; set; }

        public bool Ativo { get; set; }
    }
}

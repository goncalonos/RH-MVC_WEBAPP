using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REQGEST.Models
{
    public class Item : Entidade
    {
        public Guid FornecedorId { get; set;} /*Chave estrangueira FK*/

        
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",MinimumLength = 2 )]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        //EF Relation 

        public Fornecedor Fornecedor { get; set; } /*Um item (produto) tem apenas 1 fornecedor*/
    }
}

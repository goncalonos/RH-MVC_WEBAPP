using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REQGEST.Models
{
    public class Fornecedor : Entidade
    {
        public bool Ativo { get; set; } /*Define se o fornecedor esta ativo ou nao */

        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descrisao { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Morada { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Contacto { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(9, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 9)]
        public string Nif { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(21, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 21)]
        public string Nib { get; set; }

        //EF Relations Fornecedor tem uma relação de 1 para muitos com item

        public IEnumerable<Item> Items { get; set; } /*Um fornecdor pode ter varios produtos 
*/

    }
}

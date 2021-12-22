using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REQGEST.Models
{
    public class Requisicao : Entidade
    {
        //È necessario a FK do colaborador?????

        public Guid Item { get; set; }

        public DateTime Data_Requesicao { get; set; }

        public string Estado_Requesicao { get; set; }

        public string Justificacao { get; set; }
         
        public string Observacao { get; set; }

        //tabela incompleta pois é necessario a classe de colaborador
  

    }
}

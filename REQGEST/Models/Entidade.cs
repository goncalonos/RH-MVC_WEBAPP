using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REQGEST.Models
{
    public abstract class Entidade /*Classe mae todas as outras derivam desta */
    {
        protected Entidade() /*classe que so pode ser herdada por isso é protected*/
        {
            Id = Guid.NewGuid();
        }
        

        public Guid Id { get; set; }
    }
}

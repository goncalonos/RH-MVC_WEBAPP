using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REQGEST.Models
{
    public class Stock : Entidade
    {
        public Guid Item { get; set; }

        public DateTime Date_Stock { get; set; }

        public int Quantidade { get; set; }

        public IEnumerable<Item> Items { get; set; }
    }
}

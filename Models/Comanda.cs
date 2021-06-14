using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioFresh.Models
{
    public class Comanda
    {
       public Guid ID { get; set; }
        public int TimpDeLivrare { get; set; }
        public string DateDeContact { get; set; }
        public double PretTotal { get; set; }
    }
}

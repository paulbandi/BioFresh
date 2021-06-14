using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioFresh.Models
{
    public class Livrare
    {
        public Guid ID { get; set; }
        public string RidicareComanda { get; set; }
        public string LivrareComanda { get; set; }
    }
}

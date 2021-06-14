using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioFresh.Models
{
    public class Recenzie
    {
        public Guid ID { get; set; }
        public string Nume { get; set; }
        public string Data { get; set; }
        public string Notita { get; set; }
        public int Stele { get; set; }

    }
}

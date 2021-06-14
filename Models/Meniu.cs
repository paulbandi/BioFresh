using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioFresh.Models
{
    public class Meniu
    {
        public Guid ID { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Calorii { get; set; }
        public double Pret { get; set; }
    }
}
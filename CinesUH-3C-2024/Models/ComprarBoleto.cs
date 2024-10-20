using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinesUH_3C_2024.Models
{
    public class ComprarBoleto
    {
        public int Id { get; set; }
        public int CantidadBoletos  { get; set; }

        public int CostoBoleto { get; set; }

        public ComprarBoleto() 
        { 
        }  
    }
}

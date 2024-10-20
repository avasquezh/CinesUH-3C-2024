using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinesUH_3C_2024.Models
{
    public class SalasUH
    { 
        public int Id { get; set; }  
        public string Sala { get; set; }
        public string Pelicula { get; set; }
        public string Horario { get; set; }

        public SalasUH() 
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
     public class Vagao
    {
        public int Id { get; set; }
        public string Carga { get; set; }
        public int PesoEmToneladas { get; set; }
        public Vagao Atras { get; set; }
    }
}

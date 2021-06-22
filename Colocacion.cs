using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectobis
{
    public class Colocacion
    {
        public int ColocacionId { get; set; }
        public int OfertaTrabajadorId { get; set; }
        public int TipoContrato { get; set; }
        public int OfertaId { get; set; }
        public int TrabajadorId { get; set; }
        public DateTime FechaColocacion { get; set; }

        //Navegacion:
        public virtual OfertaTrabajador OfertaTrabajador { get; set; }

    }
}

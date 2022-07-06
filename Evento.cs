using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    abstract class Evento
    {
        public string titolo { get; set; }

        public DateTime data { get; set; }

        public int capienzaMassina { get; }

        public int postiPrenotati { get; }
        public abstract void PrenotaPosti(int param);
        public abstract void DisdiciPosti(int param);

    }
}

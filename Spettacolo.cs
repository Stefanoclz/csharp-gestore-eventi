using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Spettacolo : Evento
    {
        public string titolo { get; set; }
        public DateTime data { get; set; }
        public int capienzaMassima { get; private set; }
        public int postiPrenotati { get; private set;  }

        public Spettacolo(string titolo, DateTime data, int postiDisponibili)
        {
            if (titolo.Length > 0)
            {
                this.titolo = titolo;
            }
            DateTime todayFull = DateTime.Now;

            if (data > todayFull)
            {
                this.data = data;
            }

            if (postiDisponibili > 0)
            {
                this.capienzaMassima = postiDisponibili;
            }

            this.postiPrenotati = 0;
        }

        public override void PrenotaPosti(int param)
        {

            int postiDisp = this.capienzaMassima - this.postiPrenotati;

            if (param > 0 && param < postiDisp)
            {
                this.postiPrenotati += param;
            }

            Console.WriteLine($"Prenotazione effettuata! Hai prenotato {param} posti, Capacità massima {this.capienzaMassima}, Posti prenotati {this.postiPrenotati}");
        }

        public override void DisdiciPosti(int param)
        {

            int postiDisp = this.capienzaMassima - this.postiPrenotati;

            if (param > 0 && param <= postiDisp)
            {
                this.postiPrenotati -= param;
            }

            Console.WriteLine($"Disdetta effettuata! Hai disdetto {param} posti, Capacità massima {this.capienzaMassima}, Posti prenotati {this.postiPrenotati}");
        }
    }
}

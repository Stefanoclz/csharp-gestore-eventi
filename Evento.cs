using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        public string titolo { get; set; }
        public DateTime data { get; set; }
        public int capienzaMassima { get; private set; }
        public int postiPrenotati { get; private set; }

        public Evento(string titolo, DateTime data, int postiDisponibili)
        {

            this.titolo = titolo;

            this.data = data;

            this.capienzaMassima = postiDisponibili;

            this.postiPrenotati = 0;
        }

        public void PrenotaPosti(int param)
        {

            int postiDisp = this.capienzaMassima - this.postiPrenotati;

            if (param > 0 && param < postiDisp)
            {
                this.postiPrenotati += param;
            }

            Console.WriteLine($"Prenotazione effettuata! Hai prenotato {param} posti, Capacità massima {this.capienzaMassima}, Posti prenotati {this.postiPrenotati}, posti disponibili: {this.capienzaMassima - this.postiPrenotati}");
        }

        public void DisdiciPosti(int param)
        {

            if (param <= this.postiPrenotati)
            {
                this.postiPrenotati -= param;
            }
            else
            {
                Console.WriteLine("Numero troppo alto!");
            }


            Console.WriteLine($"Disdetta effettuata! Hai disdetto {param} posti, Capacità massima {this.capienzaMassima}, Posti prenotati {this.postiPrenotati}, posti disponibili: {this.capienzaMassima - this.postiPrenotati}");
        }


        public override string ToString()
        {
            return data.ToString("dd/MM/yyyy") + " - " + this.titolo;
        }
 

    }
}

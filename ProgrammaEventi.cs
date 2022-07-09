using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        string titolo = "";
        List<Evento> eventi;

        Evento prima = new Evento("Dalla scimmia all'uomo", DateTime.Parse("27/09/2022"), 350);
        Evento seconda = new Evento("La psiche nell'informatica", DateTime.Parse("15/11/2022"), 450);
        Evento terza = new Evento("Storia delle graffette", DateTime.Parse("15/01/2023"), 150);

        
        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();
            eventi.Add(prima);
            eventi.Add(seconda);
            eventi.Add(terza);
        }

        internal void AddEventi(Evento param)
        {
            eventi.Add(param);
        }

        public void StampaEventi()
        {
            Console.WriteLine("LISTA EVENTI COMPLESSIVI:");

            foreach (Evento param in eventi)
            {
                Console.WriteLine($"Titolo: {param.titolo} | data: {param.data} | posti disponibili: {param.capienzaMassima - param.postiPrenotati}");
            }
        }
    }
}

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

        public void CercaEventi()
        {
            Console.WriteLine("Inserisci la data degli eventi da cercare: ");
            DateTime data = DateTime.Parse(Console.ReadLine());


            List<Evento> trovati = new List<Evento>();

            foreach (Evento evento in eventi)
            {
                if (evento.data == data)
                {
                    trovati.Add(evento);
                }
            }

            foreach (Evento eventoInData in trovati)
            {
                Console.WriteLine("EVENTI TROVATI:");
                Console.WriteLine($"Titolo: {eventoInData.titolo} | data: {eventoInData.data} | posti disponibili: {eventoInData.capienzaMassima - eventoInData.postiPrenotati}");
            }
        }

        public void TotEventi()
        {
            int eventiTotali = this.eventi.Count();
            Console.WriteLine($"Attualmente sono in programma {eventiTotali} eventi");
        }

        public void CancellaEventi()
        {
            Console.WriteLine("Vuoi eliminare tutti gli eventi in programma? si/no");
            string scelta = Console.ReadLine();
            if(scelta == "si")
            {
                eventi.Clear();
            }
            else
            {
                Console.WriteLine("EVENTI IN PROGRAMMA: ");
                StampaEventi();
            }
        }

        public void RiassuntoEventi()
        {
            Console.WriteLine($"Nome programma evento: {this.titolo}");
            foreach(Evento evento in eventi)
            {
                string resume = evento.ToString();
                Console.WriteLine(resume);
            }
        }
    }
}

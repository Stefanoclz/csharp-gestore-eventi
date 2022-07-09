﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Gestionale
    {
        List<Conferenza> conferenzeList = new List<Conferenza>();
        List<Concerto> concertiList = new List<Concerto>();
        List<Spettacolo> spettacoliList = new List<Spettacolo>();


        Conferenza prima = new Conferenza("Dalla scimmia all'uomo", DateTime.Parse("27/09/2022"), 350);
        Conferenza seconda = new Conferenza("La psiche nell'informatica", DateTime.Parse("15/11/2022"), 450);
        Conferenza terza = new Conferenza("Storia delle graffette", DateTime.Parse("15/01/2023"), 150);

        Concerto IronMaiden = new Concerto("Beast Tour", DateTime.Parse("16/03/2023"), 20250);
        Concerto DeepPurple = new Concerto("Maybe The Last", DateTime.Parse("13/12/2022"), 18000);
        Concerto Tool = new Concerto("Blind Wild Side", DateTime.Parse("25/04/2023"), 15950);

        Spettacolo spett1 = new Spettacolo("Cena con delitto", DateTime.Parse("12/08/2022"), 150);
        Spettacolo spett2 = new Spettacolo("Cats", DateTime.Parse("12/08/2022"), 800);
        Spettacolo spett3 = new Spettacolo("Amleto", DateTime.Parse("12/02/2023"), 950);

        public Gestionale()
        {
            this.conferenzeList.Add(prima);
            this.conferenzeList.Add(seconda);
            this.conferenzeList.Add(terza);

            this.concertiList.Add(IronMaiden);
            this.concertiList.Add(DeepPurple);
            this.concertiList.Add(Tool);

            this.spettacoliList.Add(spett1);
            this.spettacoliList.Add(spett2);
            this.spettacoliList.Add(spett3);
        }

        internal Concerto CreaNuovoConcerto()
        {

            Console.WriteLine("Inseriscil titolo del concerto");
            string titolo = Console.ReadLine();

            if (titolo.Length <= 0)
            {
                Console.WriteLine("Devi inserire un titolo valido!");
                CreaNuovoConcerto();
            }

            Console.WriteLine("inserisci la data dell'evento");
            DateTime data = DateTime.Parse(Console.ReadLine());

            DateTime todayFull = DateTime.Now;

            if (data < todayFull)
            {
                Console.WriteLine("Data inserita già passata!");
                CreaNuovoConcerto();
            }

            Console.WriteLine("Inseriscil Il numero di posti disponibili");
            int posti = Int32.Parse(Console.ReadLine());

            if (posti <= 0)
            {
                Console.WriteLine("Deve esserci almeno 1 posto!");
                CreaNuovoConcerto();
            }
       
            Concerto nuovoConcerto = new Concerto(titolo, data, posti);
            Console.WriteLine("Concerto creato!");
            Console.WriteLine($"Nome: {titolo} Data: {data} posti disponibili: {posti}");

            return nuovoConcerto;
        }

        internal Conferenza CreaNuovoConferenza()
        {

            Console.WriteLine("Inseriscil titolo dell'evento");
            string titolo = Console.ReadLine();

            if (titolo.Length <= 0)
            {
                Console.WriteLine("Devi inserire un titolo valido!");
                CreaNuovoConferenza();
            }

            Console.WriteLine("inserisci la data dell'evento");
            DateTime data = DateTime.Parse(Console.ReadLine());

            DateTime todayFull = DateTime.Now;

            if (data < todayFull)
            {
                Console.WriteLine("Data inserita già passata!");
                CreaNuovoConferenza();
            }

            Console.WriteLine("Inseriscil Il numero di posti disponibili");
            int posti = Int32.Parse(Console.ReadLine());

            if (posti <= 0)
            {
                Console.WriteLine("Deve esserci almeno 1 posto!");
                CreaNuovoConferenza();
            }

            Conferenza nuovaConferenza = new Conferenza(titolo, data, posti);
            Console.WriteLine("Conferenza creata!");
            Console.WriteLine($"Nome: {titolo} Data: {data} posti disponibili: {posti}");

            return nuovaConferenza;
        }

        internal Spettacolo CreaNuovoSpettacolo()
        {
            Console.WriteLine("Inseriscil titolo dell'evento");
            string titolo = Console.ReadLine();

            if (titolo.Length <= 0)
            {
                Console.WriteLine("Devi inserire un titolo valido!");
                CreaNuovoSpettacolo();
            }

            Console.WriteLine("inserisci la data dell'evento");
            DateTime data = DateTime.Parse(Console.ReadLine());

            DateTime todayFull = DateTime.Now;

            if (data < todayFull)
            {
                Console.WriteLine("Data inserita già passata!");
                CreaNuovoSpettacolo();
            }

            Console.WriteLine("Inseriscil Il numero di posti disponibili");
            int posti = Int32.Parse(Console.ReadLine());

            if (posti <= 0)
            {
                Console.WriteLine("Deve esserci almeno 1 posto!");
                CreaNuovoSpettacolo();
            }

            Spettacolo nuovoSpettacolo = new Spettacolo(titolo, data, posti);
            Console.WriteLine("Spettacolo creato!");
            Console.WriteLine($"Nome: {titolo} Data: {data} posti disponibili: {posti}");

            return nuovoSpettacolo;
        }



    }
}

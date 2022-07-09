// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;

Gestionale start = new Gestionale();

Console.WriteLine("Che nuovo evento vuoi creare?");
Console.WriteLine("1. Conferenza");
Console.WriteLine("2. Concerto");
Console.WriteLine("3. Spettacolo");
int selettore = Int32.Parse(Console.ReadLine());

if(selettore == 1)
{
    Conferenza nuovaConferenza = start.CreaNuovoConferenza();
    Console.WriteLine("Quanti posti vuoi prenotare?");
    int prenotazioni = Int32.Parse(Console.ReadLine());
    nuovaConferenza.PrenotaPosti(prenotazioni);
    Console.WriteLine("Vuoi disdire dei posti?In caso indica quanti:");
    int disdici = Int32.Parse(Console.ReadLine());
    nuovaConferenza.DisdiciPosti(disdici);
}
else if(selettore == 2)
{
    Concerto nuovoConcerto = start.CreaNuovoConcerto();
    Console.WriteLine("Quanti posti vuoi prenotare?");
    int prenotazioni = Int32.Parse(Console.ReadLine());
    nuovoConcerto.PrenotaPosti(prenotazioni);
    Console.WriteLine("Vuoi disdire dei posti?In caso indica quanti:");
    int disdici = Int32.Parse(Console.ReadLine());
    nuovoConcerto.DisdiciPosti(disdici);
}
else if (selettore == 3)
{
    Spettacolo nuovoSpettacolo = start.CreaNuovoSpettacolo();
    Console.WriteLine("Quanti posti vuoi prenotare?");
    int prenotazioni = Int32.Parse(Console.ReadLine());
    nuovoSpettacolo.PrenotaPosti(prenotazioni);
    Console.WriteLine("Vuoi disdire dei posti?In caso indica quanti:");
    int disdici = Int32.Parse(Console.ReadLine());
    nuovoSpettacolo.DisdiciPosti(disdici);
}




// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;


Gestionale nuovo = new Gestionale();
ProgrammaEventi program = new ProgrammaEventi("TicketTwo");
/*
Evento nuovoEvento = nuovo.CreaNuovoEvento();
program.AddEventi(nuovoEvento);
Console.WriteLine("Quanti posti vuoi prenotare?");
int prenotazioni = Int32.Parse(Console.ReadLine());
nuovoEvento.PrenotaPosti(prenotazioni);
while(nuovoEvento.postiPrenotati > 0)
{
    Console.WriteLine("Vuoi disdire dei posti? si/no");
    string answer = Console.ReadLine();

    if (answer == "si")
    {
        Console.WriteLine("Quanti posti vuoi disdire?");
        int disdici = Int32.Parse(Console.ReadLine());
        nuovoEvento.DisdiciPosti(disdici);
    }
    else
    {
        program.StampaEventi();
        break;
    }
}

program.CercaEventi();
Console.WriteLine("Vuoi sapere quanti eventi sono in programma? si/no");
string decision = Console.ReadLine();
if(decision == "si")
{
    program.TotEventi();
}

program.CancellaEventi();*/
program.RiassuntoEventi();










/*
Gestionale start = new Gestionale();
ProgrammaEventi program = new ProgrammaEventi("TicketTwo");

Console.WriteLine("Che nuovo evento vuoi creare?");
Console.WriteLine("1. Conferenza");
Console.WriteLine("2. Concerto");
Console.WriteLine("3. Spettacolo");
int selettore = Int32.Parse(Console.ReadLine());

if(selettore == 1)
{
    Conferenza nuovaConferenza = start.CreaNuovoConferenza();
    program.StampaEventi();
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
    program.StampaEventi();
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
    program.StampaEventi();
    Console.WriteLine("Quanti posti vuoi prenotare?");
    int prenotazioni = Int32.Parse(Console.ReadLine());
    nuovoSpettacolo.PrenotaPosti(prenotazioni);
    Console.WriteLine("Vuoi disdire dei posti?In caso indica quanti:");
    int disdici = Int32.Parse(Console.ReadLine());
    nuovoSpettacolo.DisdiciPosti(disdici);
}
*/



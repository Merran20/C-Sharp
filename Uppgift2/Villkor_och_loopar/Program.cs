using System;
using System.Security.Claims;

namespace Villkor_och_loopar
{

    /// <summary>


    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int startnummer = 0;
            int startTimme = 0;
            int StartMinut = 0;
            int startSekund = 0;
            int stopTimme = 0;
            int stopMinut = 0;
            int stopSekund = 0;
            int bästastartnummer = 0;
            int bästatid = int.MaxValue;
            int antaltävlande = 0;
            int sluttudsekunder = 0;
            int starttidsekunder = 0;
            int bästasluttimme = 0;
            int bästaslutminut = 0;
            int bästaslutsekund = 0;


            bool förstatävlande = true;

            while (true)
            {
                Console.WriteLine("Skriv in startnummer!");
                startnummer = Convert.ToInt32(Console.ReadLine());

                if (startnummer < 1)
                {
                    break;

                }

                antaltävlande++;

                Console.WriteLine("Skriv in Starttimme!");
                startTimme = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv in Startminut!");
                StartMinut = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv in Startsekud!");
                startSekund = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv in Stoptimme!");
                stopTimme = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv in stopminut!");
                stopMinut = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv in stopsekund!");
                stopSekund = Convert.ToInt32(Console.ReadLine());

                starttidsekunder = startTimme * 3600 + StartMinut * 60 + startSekund;
                sluttudsekunder = stopTimme * 3600 + stopMinut * 60 + stopSekund;

                if (sluttudsekunder < 0)
                {
                    sluttudsekunder += (24 * 3600);
                }

                if (sluttudsekunder < bästatid)
                {
                    bästastartnummer = startnummer;

                    bästatid = sluttudsekunder;


                }
                Console.WriteLine($"startnummer {bästastartnummer} är vinnaren");

                bästasluttimme = (int)Math.Floor((decimal)bästatid / 3600);
                bästaslutminut = (int)Math.Floor((decimal)bästatid / 60) - bästasluttimme * 3600;
                bästaslutsekund = bästatid % 60;

                Console.WriteLine($"Vinnande sluttid: {bästasluttimme} timmar {bästaslutminut} minuter {bästaslutsekund} sekund");
                Console.WriteLine($"Antal tävlane: {antaltävlande}");

                Console.ReadLine();
















            }
        }
    }
}

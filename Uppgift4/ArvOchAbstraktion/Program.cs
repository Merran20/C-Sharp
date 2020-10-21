using System;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
using Klasser; //Depencies, add projekt, ok 

namespace ArvOchAbstraktion
{
    class Program
    {
        class Bil : Fordon
        {

            public bool HardDragKrok { get; set; }

        }
        class Motorcykel : Fordon
        {

            public int maxfart { get; set; }

        }
        class lastbil : Fordon
        {


            public int maxLastiKilo { get; set; }

        }
        class buss : Fordon
        {

            public int maxAntalPassagrare { get; set; }

            public static implicit operator int(buss v)
            {
                throw new NotImplementedException();
            }

            class Program
            {
                private static string modelnamn;

                public static void Main(string[] args)
                {

                    IVerkstad vs = new Verkstad();  // vs förkortning av verkstad.  

                    while (true)
                    {
                        Console.WriteLine("Ange någon av alternatien  ");

                        Console.WriteLine("1.Skapa bil ");
                        Console.WriteLine("2.Skapa motorcykel ");
                        Console.WriteLine("3.Skapa lastbil ");
                        Console.WriteLine("4.Skapa buss ");
                        Console.WriteLine("5.Avsluta ");


                        int alternativ = int.Parse(Console.ReadLine()); //använd Try.Parse för att det inte ska crasha om man skriver ej siffra 
                        if (alternativ == 5)
                        {
                            break;
                        }

                        Fordon f = null;


                        switch (alternativ)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                        }
                        vs.AddFordon(f);


                    }


                }


                public static Motorcykel createmotorcykel()
                {
                    string regnumer;
                    int mätare;
                    DateTime registreringsdatum;
                    string modelnamn;
                    CreateFordon(out modelnamn, out regnumer, out mätare, out registreringsdatum);
                    Console.WriteLine("Ange maxfart:");
                    int maxfart = int.Parse(Console.ReadLine());
                    Motorcykel mc = new Motorcykel
                    {
                        maxfart = maxfart,
                        modelnamn = modelnamn,
                        regnummer = regnumer,
                        mätare = mätare,
                        regdatum = registreringsdatum

                        //gör klart alla propertys och returna mc 
                    };
                    return mc;

                }


                public static Bil CreateBil()
                {
                    string regnumer;
                    int mätare;
                    DateTime registreringsdatum;
                    CreateFordon(out modelnamn, out regnumer, out mätare, out registreringsdatum);
                    Console.WriteLine("Har bilen dragkrok? j/n ");
                    string svar = Console.ReadLine();
                    bool harDragKrok = false;
                    if (svar == "j")
                    {
                        harDragKrok = true;
                    }

                    Bil bil = new Bil
                    {
                        HardDragKrok = harDragKrok,
                        mätare = mätare,
                        regnummer = regnumer,
                        regdatum = registreringsdatum,
                        modelnamn = modelnamn

                    };

                    return bil;
                }
                public static lastbil CreateLastbil()
                {
                    string regnumer;
                    int mätare;
                    DateTime registreringsdatum;
                    CreateFordon(out modelnamn, out regnumer, out mätare, out registreringsdatum);
                    Console.WriteLine("Ange maxfart:");
                    int maxkilolast = int.Parse(Console.ReadLine());
                    lastbil last = new lastbil
                    {
                        maxLastiKilo = maxkilolast,
                        modelnamn = modelnamn,
                        regnummer = regnumer,
                        mätare = mätare,
                        regdatum = registreringsdatum

                        //gör klart alla propertys och returna mc 
                    };
                    return last;

                }
                public static buss CreateLastbil()
                {
                    string regnumer;
                    int mätare;
                    DateTime registreringsdatum;
                    CreateFordon(out modelnamn, out regnumer, out mätare, out registreringsdatum);
                    Console.WriteLine("Ange maxfart:");
                    int maxantalpassagrerae = int.Parse(Console.ReadLine());
                    buss maxantal = new buss
                    {
                        maxAntalPassagrare = maxantal,
                        modelnamn = modelnamn,
                        regnummer = regnumer,
                        mätare = mätare,
                        regdatum = registreringsdatum

                        //gör klart alla propertys och returna mc 
                    };
                    return maxantal;

                    public static void CreateFordon(out string modelnamn, out string regnumer, out int mätare, out DateTime registreringsdatum)
                    {
                        Console.WriteLine("Ange modellnamn");
                        string modellnamn = Console.ReadLine();
                        Console.WriteLine("Ange regnummer");
                        regnumer = Console.ReadLine();
                        Console.WriteLine("Ange mätare");
                        mätare = int.Parse(Console.ReadLine());
                        registreringsdatum = DateTime.Now;
                    }
                }
            }
        }
    } }

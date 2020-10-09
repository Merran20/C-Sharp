using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Klasser
{
    class person
    {

        public string Namn { get; set; }
        public int age { get; set; }

        public List<Bil> PersonBilList { get; set; }

        public person(List<Bil> bilar) 
        {
            PersonBilList = bilar;
        }

    }




    class Bil
    {

        public string vikt { get; set; }
        public DateTime Registrerades { get; set; }

        public bool Elbil { get; set;  }

        public Bil(string model)
        {
            this.model = model; 
        }

        public string model;
        private int mätarställning; 

        public void mätarställning_update(int x)
        {
            mätarställning = mätarställning + x; 
        }

        public string mätarställning_Get()
        {
            return mätarställning.ToString(); 
        }


    }

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt bilmärke!");
            Bil bil1 = new Bil(Console.ReadLine());
            Console.WriteLine("Skriv in bilens vikt");
            bil1.vikt = Console.ReadLine(); 
    
            bil1.Registrerades = DateTime.Now;
            bil1.Elbil = false;
            bil1.mätarställning_update(56);

            Console.WriteLine("Skriv in ditt bilmärke!");
            Bil bil2 = new Bil(Console.ReadLine());
            Console.WriteLine("Skriv in bilens vikt");
            bil2.vikt = Console.ReadLine();
            bil2.Registrerades = DateTime.Now;
            bil2.Elbil = false;
            bil2.mätarställning_update(32);

            Console.WriteLine("Skriv in ditt bilmärke!");
            Bil bil3 = new Bil(Console.ReadLine());
            Console.WriteLine("Skriv in bilens vikt");
            bil3.vikt = Console.ReadLine();
            bil3.Registrerades = DateTime.Now;
            bil3.Elbil = true;
            bil3.mätarställning_update(55);

            Console.WriteLine("Skriv in ditt bilmärke!");
            Bil bil4 = new Bil(Console.ReadLine());
            Console.WriteLine("Skriv in bilens vikt");
            bil4.vikt = Console.ReadLine();
            bil4.Registrerades = DateTime.Now;
            bil4.Elbil = true;
            bil4.mätarställning_update(66);


            List<Bil> _bilar1 = new List<Bil>();
            List<Bil> _bilar2 = new List<Bil>();

            _bilar1.Add(bil1);
            _bilar1.Add(bil2);

            _bilar2.Add(bil1);
            _bilar2.Add(bil3);
            _bilar2.Add(bil4);


            /*---------------------*/
            person person1 = new person(_bilar1);

            Console.WriteLine("Mata in ditt namn");
            person1.Namn = Console.ReadLine();
            Console.WriteLine("Mata in ditt ålder");
            person1.age = int.Parse(Console.ReadLine());

            person person2 = new person(_bilar2);
             Console.WriteLine("Mata in ditt namn");
            person1.Namn = Console.ReadLine();
            Console.WriteLine("Mata in ditt ålder");
            person1.age = int.Parse(Console.ReadLine());

            /*---------------------*/

            List<person> peoples = new List<person>();
            peoples.Add(person1);
            peoples.Add(person2);

            foreach (var item in peoples)
            {
                Console.WriteLine($"Jag heter : {item.Namn} och är - {item.age} gammal");
                foreach (var item2 in item.PersonBilList)
                {
                    Console.WriteLine($"{item2.model}");
                    
                    Console.WriteLine($"{item2.vikt}");
                    Console.WriteLine($"{item2.Registrerades}");
                    Console.WriteLine($"{item2.Elbil}");
                    if (item2.Elbil)
                    {
                        Console.WriteLine($"Det är elbil");
                    }
                    else
                    {
                        Console.WriteLine($"Det är inte elbil");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("-------");



            }
            Console.ReadLine(); 














        }
    }

   
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public abstract class Fordon // lägger till abstract för att vi är intresserade av Classerna so fordon innehåller inte fordon. 
    {
        public string modelnamn { get; set; }  //property 

        public string regnummer { get; set; }

        public int mätare { get; set; }

        public DateTime regdatum { get; set; }

    }
}

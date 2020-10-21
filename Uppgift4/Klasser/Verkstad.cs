using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Verkstad : IVerkstad
    {
        private List<Fordon> _fordon = new List<Fordon>();     //alla fält döper man med understrek 
        public void AddFordon(Fordon fordon)
        {
            _fordon.Add(fordon); //stoppar in fordon som man skickar till metoden.  
        }

        public void RemooveFordon(Fordon fordon) //som tar boortfordon 
        {
            _fordon.Remove(fordon); 
            // nu har vi implementerat interface som vi skulle iplementera. 
        }
    }
}

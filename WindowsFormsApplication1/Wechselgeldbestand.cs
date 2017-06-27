using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Wechselgeldbestand
    {
        private Muenzrepresentation mBestand;
        
        public Muenzrepresentation _mBestand
        {
            get
            {
                return _mBestand;
            }
            set
            {
                _mBestand = value;
            }
        }

        public Wechselgeldbestand(Muenzrepresentation m){
            mBestand = m;
        }

        public override string ToString()
        {
            //TODO 
            return "Zwanziger: "+ mBestand.getmAnzahlZwanziger() + " , Zehner: " + mBestand.getmAnzahlZehner()
        }


    }
}

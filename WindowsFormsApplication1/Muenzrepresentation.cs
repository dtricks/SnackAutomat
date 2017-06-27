using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Muenzrepresentation
    {
        private int mAnzahlZwanziger;
        private int mAnzahlZehner;
        private int mAnzahlFuenfer;
        private int mAnzahlZweiEuroMuenzen;
        private int mAnzahlEinEuroMuenzen;
        private int mAnzahlFuenfzigCentMuenzen;
        private int mAnzahlZwanzigCentMuenzen;
        private int mAnzahlZehnCentMuenzen;
        private int mAnzahlFuenfCentMuenzen;

        public Muenzrepresentation(int pAnzahlZwanziger, int pAnzahlZehner, int pAnzahlFuenfer, int pAnzahlZweiEuroMuenzen, int pAnzahlEinEuroMuenzen, int pAnzahlFuenfzigCentMuenzen, int pAnzahlZwanzigCentMuenzen, int pAnzahlZehnCentMuenzen, int pAnzahlFuenfCentMuenzen)
        {
            mAnzahlZwanziger = pAnzahlZwanziger;
            mAnzahlZehner = pAnzahlZehner;
            mAnzahlFuenfer = pAnzahlFuenfer;
            mAnzahlZweiEuroMuenzen = pAnzahlZweiEuroMuenzen;
            mAnzahlEinEuroMuenzen = pAnzahlEinEuroMuenzen;
            mAnzahlFuenfzigCentMuenzen = pAnzahlFuenfzigCentMuenzen;
            mAnzahlZwanzigCentMuenzen = pAnzahlZwanzigCentMuenzen;
            mAnzahlZehnCentMuenzen = pAnzahlZehnCentMuenzen;
            mAnzahlFuenfCentMuenzen = pAnzahlFuenfCentMuenzen;
        }

        public int getmAnzahlZwanziger(){
            return mAnzahlZwanziger;
        }
        public int getmAnzahlZehner()
        {
            return mAnzahlZehner;
        }
        public int getmAnzahlFuenfer()
        {
            return mAnzahlFuenfer;
        }
        public int getmAnzahlZweiEuroMuenzen()
        {
            return mAnzahlZweiEuroMuenzen;
        }
        public int getmAnzahlEinEuroMuenzen()
        {
            return mAnzahlEinEuroMuenzen;
        }
        public int getmAnzahlFuenfzigCentMuenzen()
        {
            return mAnzahlFuenfzigCentMuenzen;
        }
        public int getmAnzahlZwanzigCentMuenzen()
        {
            return mAnzahlZwanzigCentMuenzen;
        }
        public int getmAnzahlZehnCentMuenzen()
        {
            return mAnzahlZehnCentMuenzen;
        }
        public int getmAnzahlFuenfCentMuenzen()
        {
            return mAnzahlFuenfCentMuenzen;
        }

        public void setmAnzahlZwanziger(int neu)
        {
            mAnzahlZwanziger = neu;
        }
        public void setmAnzahlZehner(int neu)
        {
            mAnzahlZehner = neu;
        }
        public void setmAnzahlFuenfer(int neu)
        {
            mAnzahlFuenfer = neu;
        }
        public void setmAnzahlZweiEuroMuenzen(int neu)
        {
            mAnzahlZweiEuroMuenzen = neu;
        }
        public void setmAnzahlEinEuroMuenzen(int neu)
        {
            mAnzahlEinEuroMuenzen = neu;
        }
        public void setmAnzahlFuenfzigCentMuenzen(int neu)
        {
            mAnzahlFuenfzigCentMuenzen = neu;
        }
        public void setmAnzahlZwanzigCentMuenzen(int neu)
        {
            mAnzahlZwanzigCentMuenzen = neu;
        }
        public void setmAnzahlZehnCentMuenzen(int neu)
        {
            mAnzahlZehnCentMuenzen = neu;
        }
        public void setmAnzahlFuenfCentMuenzen(int neu)
        {
            mAnzahlFuenfCentMuenzen = neu;
        }



    }
}

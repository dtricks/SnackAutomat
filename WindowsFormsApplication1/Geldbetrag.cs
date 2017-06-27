using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Geldbetrag
    {
        private float mBetrag;
        //private Muenzrepresentation mRep;

        public Geldbetrag(float betrag)
        {
            mBetrag = betrag;
            //mRep = münzRepBerechnen(betrag);
        }

        public float getmBetrag()
        {
            return mBetrag;
        }

        public void setmBetrag(float newBetrag)
        {
            mBetrag = newBetrag;
        }

    }
}

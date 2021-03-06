﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht8
{
    class Cirkel
    {
        //Fields
        int straal;

        //Constructors
        public Cirkel()
        {
            straal = 5;
        }
        public Cirkel(int straal)
        {
            this.straal = straal;
        }

        //Methods
        public void VeranderStraal(int nieuweStraal)
        {
            straal = nieuweStraal;
        }

        public double Oppervlakte()
        {
            return (Math.Pow(straal, 2) * Math.PI);
        }

        public double Omtrek()
        {
            return ((Math.PI * 2) * straal);
        }
    }
}

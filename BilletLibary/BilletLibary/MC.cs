using System;
using System.Data;

namespace BilletLibary
{
    public class MC :BaseKlasse
    {
    

        public override decimal Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}

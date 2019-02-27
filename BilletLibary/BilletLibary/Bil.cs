using System;

namespace BilletLibary
{
    public class Bil
    {
        public string Nummerplade;
        public DateTime Dato;

        public decimal Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
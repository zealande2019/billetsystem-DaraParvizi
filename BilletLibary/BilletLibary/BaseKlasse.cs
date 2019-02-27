using System;
using System.Reflection.Metadata;

namespace BilletLibary
{
    public abstract class BaseKlasse
    {
        public string Nummerplade;
        public DateTime Dato;

        public abstract decimal Pris();
        public abstract string Køretøj();
    }
}
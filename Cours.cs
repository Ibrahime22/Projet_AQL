using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiants
{
    internal class Cours
    {
        public int NumeroCours { get; set; }
        public string Code { get; set; }
        public string Titre { get; set; }

        public Cours(int numeroCours, string code, string titre)
        {
            NumeroCours = numeroCours;
            Code = code;
            Titre = titre;
        }
    }
}

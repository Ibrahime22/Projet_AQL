using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiants
{
    internal class Notes
    {
        public int NumeroEtudiant { get; set; }
        public int NumeroCours { get; set; }
        public double Valeur { get; set; }

        public Notes(int numeroEtudiant, int numeroCours, double valeur)
        {
            NumeroEtudiant = numeroEtudiant;
            NumeroCours = numeroCours;
            Valeur = valeur;
        }

    }
}

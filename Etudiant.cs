using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiants
{
    internal class Etudiant
    {
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            NumeroEtudiant = numeroEtudiant;
            Nom = nom;
            Prenom = prenom;
        }

       

    }
}

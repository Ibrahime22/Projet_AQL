using Gestion_Etudiants;

Console.WriteLine("Gestion des notes des étudiants");
Console.WriteLine("1. Enregistrer un étudiant");
Console.WriteLine("2. Enregistrer un cours");
Console.WriteLine("3. Enregistrer une note");
Console.WriteLine("4. Afficher le relevé de notes d'un étudiant");
Console.WriteLine("5. Quitter");
Console.Write("Choisissez une option : ");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        Console.Write("Entrez le numéro d'étudiant : ");
        int numeroEtudiant = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entrez le nom de l'étudiant : ");
        string nom = Console.ReadLine();
        Console.Write("Entrez le prénom de l'étudiant : ");
        string prenom = Console.ReadLine();
        Etudiant nouvelEtudiant = new Etudiant(numeroEtudiant, nom,     prenom);
        EnregistrerEtudiant(nouvelEtudiant);
        break;
    case 2:
        Console.Write("Entrez le numéro du cours : ");
        int numeroCours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entrez le code du cours : ");
        string code = Console.ReadLine();
        Console.Write("Entrez le titre du cours : ");
        string titre = Console.ReadLine();
        Cours nouvelCours = new Cours(numeroCours, code, titre);
        EnregistrerCours(nouvelCours);
        break;
    case 3:
        Console.Write("Entrez le numéro d'étudiant : ");
        int numeroEtudiantNote = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entrez le numéro du cours : ");
        int numeroCoursNote = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entrez la note : ");
        double valeur = Convert.ToDouble(Console.ReadLine());
        Notes nouvelleNote = new Notes(numeroEtudiantNote, numeroCoursNote, valeur);
        EnregistrerNote(nouvelleNote);
        break;
    case 4:
        Console.Write("Entrez le numéro d'étudiant pour afficher le relevé de notes : ");
        int numeroEtudiantAfficher = Convert.ToInt32(Console.ReadLine());
        AfficherNotesEtudiant(numeroEtudiantAfficher);
        break;
    case 5:
        Console.WriteLine("Au revoir !");
        break;
    default:
        Console.WriteLine("Option invalide.");
        break;
}

 void EnregistrerEtudiant(Etudiant etudiant)
{
    try
    {
        using (StreamWriter writer = new StreamWriter("etudiants.txt", true))
        {
            writer.WriteLine($"{etudiant.NumeroEtudiant},{etudiant.Nom},{etudiant.Prenom}");
        }
        Console.WriteLine("Les données de l'étudiant ont été enregistrées avec succès.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Une erreur s'est produite lors de l'enregistrement des données de l'étudiant : {ex.Message}");
    }
}

     void EnregistrerCours(Cours cours)
{
    try
    {
        using (StreamWriter writer = new StreamWriter("cours.txt", true))
        {
            writer.WriteLine($"{cours.NumeroCours},{cours.Code},{cours.Titre}");
        }
        Console.WriteLine("Les données du cours ont été enregistrées avec succès.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Une erreur s'est produite lors de l'enregistrement des données du cours : {ex.Message}");
    }
}

 void EnregistrerNote(Notes note)
{
    try
    {
        using (StreamWriter writer = new StreamWriter("notes.txt", true))
        {
            writer.WriteLine($"{note.NumeroEtudiant},{note.NumeroCours},{note.Valeur}");
        }
        Console.WriteLine("La note a été enregistrée avec succès.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Une erreur s'est produite lors de l'enregistrement de la note : {ex.Message}");
    }
}

        void AfficherNotesEtudiant(int numeroEtudiant)
  {
    try
    {
        using (StreamReader reader = new StreamReader("notes.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (int.Parse(parts[0]) == numeroEtudiant)
                {
                    Console.WriteLine($"Cours: {parts[1]}, Note: {parts[2]}");
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Une erreur s'est produite lors de la lecture des notes de l'étudiant : {ex.Message}");
    }
}

 void CalculerEtAfficherNoteMoyenneEtudiant(int numeroEtudiant)
{
    try
    {
        List<double> notes = new List<double>();
        using (StreamReader reader = new StreamReader("notes.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (int.Parse(parts[0]) == numeroEtudiant)
                {
                    notes.Add(double.Parse(parts[2]));
                }
            }
        }

        if (notes.Count > 0)
        {
            double noteMoyenne = notes.Average();
            Console.WriteLine($"La note moyenne de l'étudiant {numeroEtudiant} est : {noteMoyenne}");
        }
        else
        {
            Console.WriteLine($"L'étudiant {numeroEtudiant} n'a pas de notes enregistrées.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Une erreur s'est produite lors du calcul de la note moyenne de l'étudiant : {ex.Message}");
    }
}


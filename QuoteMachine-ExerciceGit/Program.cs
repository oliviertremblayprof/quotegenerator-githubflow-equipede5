using QuoteMachine_ExerciceGit;

Console.WriteLine("Bienvenue dans QuoteMachine!");
Console.WriteLine("Ce projet est collaboratif et utilise le GitHub Flow.");
Console.WriteLine("Développez une application console pour gérer et afficher des citations inspirantes.\n");
Console.WriteLine("Prochaines étapes : implémentez les fonctionnalités dans des branches distinctes.\n");
Console.WriteLine("\n=== Menu Principal ===");
Console.WriteLine("Implémentez le menu du programme dans feature/menu");

//Console.ReadKey(true);
var manager = new QuoteManager();
string path = "citations.csv";
ShowMenu(manager);



static void ShowMenu(QuoteManager manager)
{

    while (true)
    {
        Console.WriteLine("Voici les options pour le programme:");
        Console.WriteLine("Choix 1: Retourner une citation aléatoire [1]");
        Console.WriteLine("Choix 2: Ajouter une citation aléatoire [2]");
        Console.WriteLine("Choix 3: Sauvegarder dans un fichier csv [3]");
        Console.WriteLine("Choix 4: Charger les citiations à partir d'un csv [4]");
        Console.WriteLine("Quitter [5]");


        string choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                ShowRandomQuote(manager);
                break;

            case "2":
                AddNewQuote(manager);
                break;

            case "3":
                SaveQuotesToFile(manager);
                break;

            case "4":
                LoadQuotesFromFile(manager);
                break;

            case "5":
                break;

            default:
                Console.WriteLine("Mauvaise entrée");
                break;
        }
    }
}



static void ShowRandomQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] Une citation aléatoire s’afficherait ici.");
    // Exemple futur : Console.WriteLine(manager.GetRandomQuote());
}

static void AddNewQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] On ajouterait une nouvelle citation ici.");
    // Exemple futur :
    // Console.Write("Texte : ");
    // var texte = Console.ReadLine();
    // Console.Write("Auteur : ");
    // var auteur = Console.ReadLine();
    // manager.AddQuote(texte, auteur);
    // Console.WriteLine("Citation ajoutée !");
}

static void SaveQuotesToFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On sauvegarderait les citations ici.");
        // Exemple futur :
        // manager.SaveToFile("citations.txt");
        //Console.WriteLine("Citations sauvegardées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}

static void LoadQuotesFromFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On chargerait les citations ici.");
        // Exemple futur :
        // manager.LoadFromFile("citations.txt");
        //Console.WriteLine("Citations chargées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Article article1 = new("Pomme", 4.50, 250);
        Article article2 = new("Gomme", 10, 500);
        Article article3 = new("T-shirt", 2.75, 60);

        article1.Afficher();
        article2.Afficher();
        article3.Afficher();

        article1.Ajouter(200);
        article1.Afficher();

        article2.Retirer(55);
        article2.Afficher();

        article3.Retirer(20);
        article3.Afficher();

        Console.WriteLine("Entrez le nom de l'article :");
        string nom = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrEmpty(nom))
        {
            Console.WriteLine("Le nom ne peut pas être vide.");
            return;
        }

        Console.WriteLine("Entrez le prix :");
        if (!double.TryParse(Console.ReadLine(), out double prix))
        {
            Console.WriteLine("Le prix doit être un nombre.");
            return;
        }

        Console.WriteLine("Entrez la quantité :");
        if (!int.TryParse(Console.ReadLine(), out int quantite))
        {
            Console.WriteLine("La quantité doit être un nombre entier.");
            return;
        }

        Article article4 = new(nom, prix, quantite);
        article4.Afficher();
    }
}
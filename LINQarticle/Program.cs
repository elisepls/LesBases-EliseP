class Program
{
    static void Main(string[] args)
    {
        Article[] articles = new Article[3];
        articles[0] = new Article("Pomme", 4.50, 250, Article.Type.Alimentaire);
        articles[1] = new Article("Gomme", 10, 500, Article.Type.Loisir);
        articles[2] = new Article("T-shirt", 2.75, 60, Article.Type.Habillement);

        // Analyse : Requêtes LINQ de base
        var alimentaires = articles.Where(a => a.type == Article.Type.Alimentaire).ToList();
        var articlesTries = articles.OrderByDescending(a => a.prix).ToList();
        var stockTotal = articles.Sum(a => a.quantite);

        // Filtrage avec OfType
        var mixedList = new List<object> {
            new Article("Pomme", 4.50, 250, Article.Type.Alimentaire),
            "Some string",
            123,
            new Article("Gomme", 10, 500, Article.Type.Loisir)
        };
        var articlesTypes = mixedList.OfType<Article>().ToList();

        // Projection avec types anonymes
        var articlesAnonymes = articles.Select(a => new { a.nom, a.prix }).ToList();
        articlesAnonymes.ForEach(a => Console.WriteLine($"Nom: {a.nom}, Prix: {a.prix}"));

        // Manipulations : Méthodes d’extension
        articles.AfficherTous();

        // Manipulations : Expressions pour les calculs
        var valeurTotaleStock = articles.Sum(a => a.prix * a.quantite);
        Console.WriteLine($"Valeur totale du stock : {valeurTotaleStock}");

        // Sérialisation JSON
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonString = JsonSerializer.Serialize(articles, options);
        File.WriteAllText("articles.json", jsonString);

        // Désérialisation JSON
        jsonString = File.ReadAllText("articles.json");
        var articlesDeserialises = JsonSerializer.Deserialize<List<Article>>(jsonString);
        articlesDeserialises.AfficherTous();
    }
}

public static class Extensions
{
    public static void AfficherTous(this List<Article> articles)
    {
        articles.ForEach(a => Console.WriteLine($"Nom: {a.nom}, Prix: {a.prix}, Stock: {a.quantite}, Type: {a.type}"));
    }
}
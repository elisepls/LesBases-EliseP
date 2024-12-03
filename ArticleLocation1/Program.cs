    ﻿class Program
{
    static void Main(string[] args)
    {
        List<Article> articles = new List<Article> {
            new Livre("Le Petit Prince", 20, 10, Article.Type.Loisir, "1", 100),
            new Disque("Thriller", 15, 5, Article.Type.Loisir, "Label"),
            new Video("Inception", 30, 2, Article.Type.Loisir, 120),
            new Poche("A la recherche du temps perdu", 10, 20, Article.Type.Loisir, "1.A", 250, "Categorie A"),
            new Broche("Harry potter", 25, 8, Article.Type.Loisir, "1.B", 150, "Categorie B")
        };

        foreach (var article in articles)
        {
            Console.WriteLine("Coût de location pour {0}", article.CalculateRent());
        }
    }
}
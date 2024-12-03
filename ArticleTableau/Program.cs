class Program
{
    static void Main(string[] args)
    {
        Article[] articles = new Article[3];
        articles[0] = new Article("Pomme", 4.50, 250, ArticleType.Type.Alimentaire);
        articles[1] = new Article("Gomme", 10, 500, ArticleType.Type.Loisir);
        articles[2] = new Article("T-shirt", 2.75, 60, ArticleType.Type.Habillement);

        foreach (var article in articles)
        {
            article.Afficher();
        }

        articles[0].Ajouter(200);
        articles[1].Retirer(55);
        articles[2].Retirer(20);

        foreach (var article in articles)
        {
            article.Afficher();
        }
    }
}
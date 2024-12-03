   
public delegate double DiscountStrategy(Article article);

public class DiscountStrategies
{
    public static double PourcentageFixe(Article article)
    {
        return article.prix * 0.9;
    }
    public static double PourcentageTypeArticle(Article article)
    {
        switch (article.type)
        {
            case Article.Type.Alimentaire:
                return article.prix * 0.95;
            case Article.Type.Droguerie:
                return article.prix * 0.8;
            case Article.Type.Habillement:
                return article.prix * 0.7;
            case Article.Type.Loisir:
                return article.prix * 0.85;
            case Article.Type.Autre:
                return article.prix * 0.9;
            default:
                return article.prix;
        }
    }
}
    class Program
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

        DiscountStrategy discountStrategy = DiscountStrategies.PourcentageFixe;
        DiscountStrategy discountStrategyType = DiscountStrategies.PourcentageTypeArticle;

        foreach (var article in articles)
        {
            Console.WriteLine("Article : {0}", article.nom);
            Console.WriteLine("Coût de location de {0}", article.CalculateRent());
            article.PublishDetails();
            Console.WriteLine("Coût de location avec réduction de {0}", discountStrategy(article));
            Console.WriteLine("Coût de location avec réduction de {0} pour le type d'article", discountStrategyType(article));
        }
    }
}
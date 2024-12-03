public interface IRentable
{
    double CalculateRent();
}

public abstract class Publication
{
    public abstract void PublishDetails();
}

public class Article : Publication, IRentable
{
    public string nom { get; set; }
    public double prix { get; set; }
    public int quantite { get; set; }
    public Type type { get; set; }
    public enum Type
    {
        Alimentaire, Droguerie, Habillement, Loisir, Autre
    };

    public Article(string nom, double prix, int quantite, Type type)
    {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
        this.type = type;
    }

    public void Afficher()
    {
        Console.WriteLine("Article : {0}, Prix : {1}, Quantité : {2}, Type : {3}", nom, prix, quantite, type);
    }

    public void Ajouter(int qte)
    {
        if (qte > 0)
        {
            quantite += qte;
        }
        else
        {
            Console.WriteLine("La quantité à ajouter doit être un nombre entier positif.");
        }
    }

    public void Retirer(int qte)
    {
        if (qte > 0 && qte <= quantite)
        {
            quantite -= qte;
        }
        else
        {
            Console.WriteLine("Quantité invalide.");
        }
    }

    public virtual double CalculateRent()
    {
        return this.prix * 0.99;
    }

    public override void PublishDetails()
    {
        Console.WriteLine("Article: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}", nom, prix, quantite, type);
    }
}

public class Disque : Article
{
    public string label { get; set; }

    public Disque(string nom, double prix, int quantite, Type type, string label)
     : base(nom, prix, quantite, type)
    {
        this.label = label;
    }

    public override double CalculateRent()
    {
        return this.prix * 0.85;
    }

    public void Ecouter()
    {
        Console.WriteLine("Écouter le disque : {0}, Label : {1}", this.nom, this.label);
    }

    public override void PublishDetails()
    {
        Console.WriteLine("Disque: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}, Label : {4}", this.nom, this.prix, this.quantite, this.type, this.label);
    }
}

public class Livre : Article
{
    public string isbn { get; set; }
    public int nbPages { get; set; }
    public Livre(string nom, double prix, int quantite, Type type, string isbn, int nbPages)
     : base(nom, prix, quantite, type)
    {
        this.isbn = isbn;
        this.nbPages = nbPages;
    }

    public override double CalculateRent()
    {
        return this.prix * 0.9;
    }

    public override void PublishDetails()
    {
        Console.WriteLine("Livre: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}, ISBN : {4}, Nombre de pages : {5}", this.nom, this.prix, this.quantite, this.type, this.isbn, this.nbPages);
    }
}

public class Video : Article
{
    public int duree { get; set; }
    public Video(string nom, double prix, int quantite, Type type, int duree)
     : base(nom, prix, quantite, type)
    {
        this.duree = duree;
    }

    public override double CalculateRent()
    {
        return this.prix * 0.8;
    }

    new public void Afficher()
    {
        Console.WriteLine("Afficher la vidéo : {0}, Durée : {1}", this.nom, this.duree);

    }

    public override void PublishDetails()
    {
        Console.WriteLine("Vidéo: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}, Durée : {4}", this.nom, this.prix, this.quantite, this.type, this.duree);
    }
}
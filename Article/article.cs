struct Article
{
    public string nom;
    public double prix;
    public int quantite;

    public Article(string nom, double prix, int quantite)
    {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
    }

    public void Afficher()
    {
        Console.WriteLine("Nom: {0}, Prix: {1}, Quantité: {2}", nom, prix, quantite);
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
}
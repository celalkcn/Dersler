using System;

namespace Odev4;

public class Kitap
{
    public Kitap(string title, string author, int pages, int ıSBNNumarası)
    {
        Title = title;
        Author = author;
        Pages = pages;
        ISBNNumarası = ıSBNNumarası;
    }

    public string Title { get; set; }   
    public string Author { get; set; }

    public int Pages { get; set; }

    public int ISBNNumarası { get; set; }

    Kitap kitap = new Kitap("Anna Carella1", "Necip Fazıl", 250, 246279543);
    Kitap kitap2 = new Kitap("Anna Carella2", "Necip Fazıl", 220, 24456443);
    Kitap kitap3 = new Kitap("Anna Carella3", "Necip Fazıl", 260, 244447953);
    Kitap kitap4 = new Kitap("Anna Carella4", "Necip Fazıl", 330, 456279543);
    Kitap kitap5 = new Kitap("Anna Carella5", "Necip Fazıl", 150, 246265443);

    public virtual void Barrow(){

        System.Console.WriteLine($"adı {Title} olan kitap ödünç alınıyor");

    }
    public virtual void Return()
    {

        System.Console.WriteLine($"adı {Title} olan kitap iade ediliyor");

    }

}

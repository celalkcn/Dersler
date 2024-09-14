namespace Project21_Class_Property_Field_;


#region product








// class Product
// {


//     int id;

//     string name;


//     decimal price;

//     bool isActive;
//     // class içindeki bilgilerin dışarıya kontrollü bir şekilde açılmsaını sağlayan yapoılara Prooerty diyoruz. Yaptığımız bu işleme ise kapsulleme (ENCAPSULATION) denir.0po

//     public string Name
//     {
//         get
//         {
//             string result = name.Substring(0, 3).ToUpper();
//             return result;
//         }
//         set
//         {
//             name = value;

//         }

//     }

//     public decimal Price
//     {

//         get
//         {
//             return price;
//         }

//         set
//         {
//             if (value < 0)
//             {
//                 price = 0;
//             }
//             else
//             {
//                 price = value;
//             }

//         }


//     }

// }
#endregion


class Product





{

    // profull snippet ı hazır şekilde verir
    // private int id;
    // public int Id
    // {
    //     get { return id; }
    //     set { id = value; }
    // }


    public int Id { get; set; }
    public string Name { get; set; } = "";

    public string? Description { get; set; }  // soru isareti hata verme demek gibi bir şey

    public required string Notes { get; set; } // mutlaka veri istiyecem hata verme kardeş

    public decimal Price { get; set; }

    public bool IsActive { get; set; }

}


class Student
{
    public Student()
    {
        System.Console.WriteLine($"{DateTime.Now} zamanında yeni bir Student oluşturuldu");
    }



    public int StudentNumber { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public byte Age { get; set; }

    public bool IsActive { get; set; }

}


class Catagory
{
    public Catagory(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public Catagory(int id, string name)
    {
        Id = id;
        Name = name;
        
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    

}





class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product { Notes = "birşeyler" };

        product1.Id = 5;
        product1.Price = 800;
        System.Console.WriteLine(product1.Id);
        product1.Notes = "sdsad";


        // Product product1 = new Product();
        // product1.Name = "Iphone 14";
        // System.Console.WriteLine(product1.Name);

        // product1.Price= 60000;
        // System.Console.WriteLine(product1.Price);

        Student s1 = new Student();

    Catagory catagory1 = new Catagory(65,"asdas","sadasd");

        Catagory catagory2 = new Catagory(65, "asdas");


    }
}

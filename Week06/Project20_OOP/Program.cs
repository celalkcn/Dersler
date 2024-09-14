namespace homeWork02;


class FirstClass
{
    //Burya Sınıfın Özellik Ve Davranışlarını Kodluyor Olacagız
    // Özellik: Property
    // Davranış: Method

    public string message; //Pro
    public string age;     //Pro

    public void DisplayMessage()
    {

        System.Console.WriteLine(message);

    }
}


class Program
{
    static void Main(string[] args)
    {

        FirstClass firstClass1 = new FirstClass();
        firstClass1.message="selam";
        System.Console.WriteLine(firstClass1.message);
        firstClass1.DisplayMessage();

    }
}

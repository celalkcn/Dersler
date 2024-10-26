namespace ödev;


// 2. Kullanıcıdan bir metin alın.Bu metindeki tüm harfleri büyük harfe çeviren bir program yazın.Sadece harf karakterleri büyük harfe çevrilmeli, diğer karakterler (noktalama işaretleri vb.) olduğu gibi kalmalıdır.Örneğin, "Merhaba Dünya!" metni "MERHABA DÜNYA!" olarak ekrana yazdırılmalıdır.
class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Bir metin giriniz: ");

        string text = Console.ReadLine();

        string result = "";
        int i = 0;

        while (i < text.Length)
        {
            char karakter = text[i];

            if (char.IsLetter(karakter))
            {
                result += char.ToUpper(karakter);
            }
            else
            {
                result += karakter;

            }
            i++;
        }
        System.Console.WriteLine(result);


    }



}

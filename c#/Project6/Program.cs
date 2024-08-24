namespace Project6;

class Program
{
    static void Main(string[] args)
    {
        #region sahte


        // string fullName = "halil umut MELER";
        // int len = fullName.Length;
        // System.Console.WriteLine(fullName.ToLower());
        // System.Console.WriteLine(len);

        #endregion
        #region  fulladres

        // string address1 = "yeni umut Sitesi e blok ";
        // string address2 = "no 12 d.5  ";
        // string district = "kadıköy  ";
        // string province = "istanbul  ";

        // string fullAdress = address1 + address2 + district + province;
        // System.Console.WriteLine(fullAdress);

        // //$interpolication
        // string fullAdress2 =$"{address1}{address2}{district}{province}";
        #endregion
        #region nişantası uni

        // string text1 = "Nişantaşı";
        // string text2 = "üniversitesi";
        // string loc1 = "bayrampaşa";
        // string currentLoc = "sarıyer";
        // string date1 = "09/09/2009";
        // string date2 = "05/05/2018";
        // // bu değişkenleri kullanarak nışantaşı üniversitesi , 09.09.2009 tarihnde istanbul'un bayrampaşa lçesinde faaliyete başladoı
        // //ardından 05052018 tarihinde yine istanbulun sarıyer ilçesnde kurulan tech campus e taşındı
        // string icerik = date1 + " tarihinde istanbul'un bayrampaşa ilçesinde faaliyete başladı ardından " + date2 + "tarihinde yine istanbulun" + currentLoc + "ilcesinde kurulan tech campus e tasındı";
        // string resultMessage = $"{text1} {text2} {date1} tarihinde istanbul un {loc1} ilçesinde faaliyete başladı ardından {date2} tarihinde yine istanbulun {currentLoc} ilçesinde kurulan ech camus e tasındı";
        // System.Console.WriteLine(resultMessage);




        #endregion

        string fullName = "halil umut MELER";
        string findText = "umut";
        bool response =fullName.Contains(findText);
        System.Console.WriteLine(response);
        
        



    }
}

namespace Project15_CreateAndAssignTeams;

class Program
{
    static void Main(string[] args)
    {
        string[] students ={
            "Hakan Çakdı",
            "Tunacan Eşki",
            "Rojin Çetiz",
            "Elif Öztürk",
            "Enes Kılıçarslan",
            "aTLAS uYAR",

            "Erdem Yüce Gül",
            "Enes Can Aydemir",
            "Irmak",
            "Burhan",
            "Miraç",
            "bedirhan",

            "Melina",
            "Merve",
            "Kerem",
            "Gizem",
            "Celal",
            "Tahir",
            "Samet",
            "Aleyna",

       };
        string[] teamNames = {
    "a",
    "b",
    "c",
    "d",
    "e",
    "f"

};
        double memberCount = 4;
        int teamCount = (int)Math.Ceiling(students.Length / memberCount);

        string[] teams = new string[teamCount];
        // string dizimizi karıştırıyoruz
        Random rnd = new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length);//7

            string temp = students[i];
            students[i] = students[randomIndex];
            students[randomIndex] = temp;

        }
        foreach (string item in students)
        {
            System.Console.WriteLine(item + "\n----------");
        }


        string currentTeamName;
        for (int i = 0; i < students.Length; i += 4)
        {
            currentTeamName = teamNames[0];
            System.Console.WriteLine($"Takım Adı: {currentTeamName} ");
            for (int j = 0; j < memberCount; j++)
            {
                System.Console.WriteLine($"\t\t-{students[i + j]}");
            }
            System.Console.WriteLine();
        }


    }
}

namespace Soru9;

class Program
{

    // static void DisplayArray(int[] array){

    // foreach (var currentNumber in array)
    // {
    //     System.Console.WriteLine(currentNumber+" ");
    // }

    // }

    // static int[] GetPositiveNumbers(int[] array){

    // int count=0;
    // foreach (var currentNumber in array)
    // {
    //     if (currentNumber>0) count++;
    // }

    //     int[] positiveNumbers = new int[count];
    //     int index=0;

    //     foreach (var currentNumber in array)
    //     {
    //         if (currentNumber >0)
    //         {
    //             positiveNumbers[index]=currentNumber;
    //             index++;
    //         }
    //     }

    //    Array.Reverse(positiveNumbers);
    //    return positiveNumbers;
    // }






     static void Main(string[] args)
     {

    //     int[] array= {3, -6, -7, 8, 4, -9, 2};
    //     DisplayArray(array);
    //     int[] positiveNumbers = GetPositiveNumbers(array);

    //     int index=0;

    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         if (array[i] >0)
    //         {
    //             array[i]=positiveNumbers[index];
    //             index++;
    //         }
    //     }

    //     System.Console.WriteLine("********************");
    //     DisplayArray(array);

    //System.Console.WriteLine("*******************************************");


    int[] numbers = { 5, -6, 8, 7, -9, 10, -11, 15, -48, 75, 42 };
    int positiveCount=0;
    int[] positive = new int[numbers.Length];


    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");

        if (numbers[i] >0)
        {
            positive[positiveCount]= numbers[i];
            positiveCount++;
        }

    }
    System.Console.WriteLine();
    Array.Resize(ref positive, positiveCount);
    Array.Reverse(positive);


    foreach (var item in positive)
    {
        System.Console.Write(item+" ");
    }

    System.Console.WriteLine();

        int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >0)
                {
                numbers[i]= positive[index];
                    index++;
                }
            }

            foreach (var item in numbers)
            {
                System.Console.Write(item+" ");
            }











    }
}
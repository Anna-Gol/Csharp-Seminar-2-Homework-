public class Task2
{
    public static void Main(string[] args)
    {
        ThirdNumber();
    }

    static void ThirdNumber()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string numberText = Convert.ToString(number);

        if (numberText.Length > 2)
        {
            Console.WriteLine($"Третья цифра в числе {number} - " + numberText[2]);
        }

        else
        {
            Console.Write($"В числе {number} нет третьей цифры"); 
        }
    }

}
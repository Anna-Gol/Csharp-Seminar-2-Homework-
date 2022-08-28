public class Task1
{
    public static void Main(string[] args)
    {
        SecondNumber();
    }

    static void SecondNumber()
    {
        Console.Write("Enter number: ");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 99 && number < 1000)
        {
            int result = number / 10 % 10;
            Console.Write($"Вторая цифра числа {number} - {result}"); 
        }

        else
        {
            Console.Write($"Число {number} не трехзначное"); 
        }
    }
}


   


public class Task3
{
    public static void Main(string[] args)
    {
        DayOff();
    }

    static void DayOff()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 1 && number <= 7)
        {
            if (number == 6 || number == 7)
            {
                Console.Write("It's a day off!!!");
            }

            else
            {
                Console.Write("It's a weekday :(");
            }
        }

        else 
        {
            Console.Write("It's not the day of the week");
        }

    }
}
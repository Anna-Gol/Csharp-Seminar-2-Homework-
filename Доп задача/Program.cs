public class AdditionalTask
{
    public static void Main(string[] args)
    {
        Div();
    }

    static void Div()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.Write($"Число {number} кратно 7 и 23 одновременно");
        }
        else 
        {
            Console.Write($"Число {number} не кратно 7 и 23 одновременно");
        }
    }
}

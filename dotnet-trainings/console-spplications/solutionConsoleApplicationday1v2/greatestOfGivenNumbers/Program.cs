internal class Program
{
    private static void Main(string[] args)
    {
        GreatestInteger();
    }
    static int GetInput()
    {
        int num1;
        Console.WriteLine("Please enter the number");
        num1 = Convert.ToInt32(Console.ReadLine());
        return num1;
    }

    static void PrintResult(int result)
    {
        Console.WriteLine("The Greatest of the given numbers is" + result);
    }

    static void GreatestInteger()
    {
        int max = -1;
        int num1 = GetInput();
        for (int i = 0; num1>0 ; i++)
        {
            if (num1 >= 0)
            {
                num1=GetInput();
                if (num1 > max)
                {
                    max = num1;
                }
            }
            else
            {
                break;
            }
        }
        PrintResult(max);
    }
}
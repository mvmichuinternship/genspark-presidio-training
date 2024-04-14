internal class Program
{

    private static void Main(string[] args)
    {
        ArithmeticOperations();
    }
    //Console.WriteLine("Hello, World!");
    //string name = null;
    //int num1;
    //int num2;
    //num1 = Convert.ToInt32(name);
    //num2 = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(num1);
    //Console.WriteLine(num2);
    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    static int Mod(int num1, int num2)
    {
        return num1 % num2;
    }
    static int Sub(int num1, int num2)
    {
        return num2 - num1;
    }
    static int Mul(int num1, int num2)
    {
        return num1 * num2;
    }
    static int Div(int num1, int num2)
    {
        return num1 / num2;
    }

    static int GetInput()
    {
        int n1;
        Console.WriteLine("Please enter the the number");
        n1 = Convert.ToInt32(Console.ReadLine());
        return n1;
    }

    static void Printoutput(int result)
    {
        Console.WriteLine("The result is" + result);
    }

    static void ArithmeticOperations()
    {
        int num1 = GetInput();
        int num2 = GetInput();
        int sum = Add(num1, num2);
        int diff = Sub(num1, num2);
        int prod = Mul(num1, num2);
        int div = Div(num1, num2);
        int remainder = Mod(num1, num2);

        Printoutput(sum);
        Printoutput(diff);
        Printoutput(remainder);
        Printoutput(prod);
        Printoutput(div);
    }


}
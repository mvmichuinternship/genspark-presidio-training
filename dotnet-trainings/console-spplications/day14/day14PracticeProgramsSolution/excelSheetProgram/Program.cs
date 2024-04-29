namespace excelSheetProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelSheet excelSheet = new ExcelSheet();
            Console.WriteLine("Enter input: ");
             var result = excelSheet.ConvertToTitle(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Output \t"+ result.Result);
        }
    }
}

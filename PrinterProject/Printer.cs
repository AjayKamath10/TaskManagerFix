namespace PrinterProject
{
    public class Printer : IPrinter
    {

        public void Print(string path)
        {
            System.Console.WriteLine($"Printing .....{path}");
        }
    }
}

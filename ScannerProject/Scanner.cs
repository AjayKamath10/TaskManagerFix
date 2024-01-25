namespace ScannerProject
{
    public class Scanner : IScanner
    {
        public void Scan(string path)
        {
            System.Console.WriteLine($"Scanning .....{path}");
        }
    }
}

using PrinterProject;
using ScannerProject;

namespace PrintScannerProject
{
    public class PrintScanner : IScanner, IPrinter
    {
        private IPrinter printer ;
        private IScanner scanner ;

        public PrintScanner()
        {
            this.printer = new Printer();
            this.scanner = new Scanner();
        }

        public void Print(string documentPath)
        {
            printer.Print(documentPath);
        }

        public void Scan(string documentPath)
        {
            scanner.Scan(documentPath);
        }
    }
}

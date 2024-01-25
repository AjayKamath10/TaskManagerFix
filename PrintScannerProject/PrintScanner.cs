using PrinterProject;
using ScannerProject;

namespace PrintScannerProject
{
    public class PrintScanner : IPrintScanner
    {
        private IPrinter printer ;
        private IScanner scanner ;

        public PrintScanner()
        {
            this.printer = new Printer();
            this.scanner = new Scanner();
        }

        public void ExecutePrintTask(string documentPath)
        {
            printer.Print(documentPath);
        }

        public void ExecuteScanTask(string documentPath)
        {
            scanner.Scan(documentPath);
        }
    }
}

using PrinterProject;
using ScannerProject;
using PrintScannerProject;

namespace TaskManagerProject

{
    public static class TaskManager
    {
        
        public static void ExecutePrintTask(IPrinter printer, string documentPath)
        {
            printer.Print(documentPath);
        }
        public static void ExecuteScanTask(IScanner scanner, string documentPath)
        {
            scanner.Scan(documentPath);
        }
        public static void ExecutePrintTask(IPrintScanner printScanner, string documentPath)
        {

            printScanner.ExecutePrintTask(documentPath);
        }

        public static void ExecuteScanTask(IPrintScanner printScanner, string documentPath)
        {
            printScanner.ExecuteScanTask(documentPath);
        }
    }
}

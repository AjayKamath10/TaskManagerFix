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

    }
}

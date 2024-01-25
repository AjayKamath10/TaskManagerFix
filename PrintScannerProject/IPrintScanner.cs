using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProject
{
    public interface IPrintScanner
    {
        public void ExecutePrintTask(string documentPath);
        public void ExecuteScanTask(string documentPath);

    }
}

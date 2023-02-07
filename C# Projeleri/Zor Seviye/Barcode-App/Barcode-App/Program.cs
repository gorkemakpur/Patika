using iTextSharp.text.pdf;

namespace Barcode_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barcode barcode = Process.CreateAndSaveBarcode("111");
            Console.WriteLine(Process.ReadBarcode(barcode));

            Barcode barcode = Process.CreateAndSaveBarcode("222");
            Console.WriteLine(Process.ReadBarcode(barcode));

            Barcode barcode = Process.CreateAndSaveBarcode("333");
            Console.WriteLine(Process.ReadBarcode(barcode));
        }
    }
}
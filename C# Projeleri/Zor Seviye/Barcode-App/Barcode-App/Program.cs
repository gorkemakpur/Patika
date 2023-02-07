using iTextSharp.text.pdf;

namespace Barcode_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Barcode barcode = Process.CreateAndSaveBarcode("777");
            Console.WriteLine(Process.ReadBarcode(barcode));
        }
    }
}
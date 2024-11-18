namespace Dp.Structural.Proxy;

internal static class Program
{
    public static void Main(string[] args)
    {
        int @case = 1;

        if (args.Length > 0 && !int.TryParse(args[0], out @case))
        {
            Console.Error.WriteLine("Error parsing the first argument to integer.");
            return;
        }

        switch (@case)
        {
            case 1:
                UsingRegularPdfFile();
                break;
            case 2:
                UsingVirtualProxyPdfFile();
                break;
        }
    }

    private static void UsingRegularPdfFile()
    {
        const string FileName = "myfile.pdf";

        Console.WriteLine("Creating the normal PdfFile");

        var pdfFile = new PdfFile(FileName);

        Console.WriteLine("Done creating the normal PdfFile");

        Console.WriteLine(pdfFile.Content);
    }

    private static void UsingVirtualProxyPdfFile()
    {
        const string FileName = "myfile.pdf";

        Console.WriteLine("Creating the virtual proxy PdfFile");

        var pdfFile = new VirtualProxyPdfFile(FileName);

        Console.WriteLine("Done creating the virtual proxy PdfFile");

        Console.WriteLine(pdfFile.Content);
    }
}

// See https://aka.ms/new-console-template for more information
using SAYAYOUTUBEVIDEO;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo vid1 = new SayaTubeVideo(
                "Tutorial Design by Contract - Muhammad Nagif");
            Console.WriteLine("Memutar video sebanyak 123 kali...");
            Console.WriteLine();
            vid1.IncreasePlayCount(123);
            vid1.PrintVideoDetails();
            Console.WriteLine();

            Console.WriteLine("Menonton video sampai nyaris limit int");
            for (int i = 0; i <428; i++)
            {
                vid1.IncreasePlayCount(5000000);
            }
            vid1.PrintVideoDetails();
            Console.WriteLine();

            Console.WriteLine("Coba ngelewatin batas overflow...");
            vid1.IncreasePlayCount(10000000);
        }
        catch (OverflowException) 
        {
            Console.WriteLine("Overflow...");
        }
    }
}

using System;

namespace NameSpace

{
     class Program
    {
        static void Main(string[] args)
        {
            int br = 60;
            Console.WriteLine(br);
            Console.WriteLine(Storage.NekiTekst);
            Console.WriteLine(Storage.NekiKarakter);

            Storage.DirectPrint();
        }
    }
}
namespace NameSpace 
{
class Storage 
    {
      public static string NekiTekst = "Pozdrav iz NameSpace";
      public static char NekiKarakter = 'K';

        public static void DirectPrint()
        {
        Console.WriteLine("Ja sam metoda iz Storage klase");
        }
    }
}
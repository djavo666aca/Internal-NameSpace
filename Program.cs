using System;
using InternalB;

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

            Console.WriteLine(InternalA.BackupA.x);
            Console.WriteLine(InternalA.BackupA.y);

            Console.WriteLine(BackupB.c);
            Console.WriteLine(BackupB.z);
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
namespace InternalA 
{
class BackupA 
    {
    public static int x = 5; 
    public static int y = 15;
    }
}
namespace InternalB
{
    class BackupB
    {
        public static int c = 100;
        public static int z = 500;
    }
}


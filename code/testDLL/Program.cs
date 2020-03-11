using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CS_Create_Use_DLL;
namespace testDLL
{
    class Program
    {
        static void Pause()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Class1 x = new Class1();//用new 建立類別實體
            String StrData = "jash.liao";

            Console.WriteLine("{0} Upper {1}", StrData,x.StrUpperLower(StrData));
            Console.WriteLine("{0} Lower {1}", x.StrUpperLower(StrData), x.StrUpperLower(StrData,false));
            Pause();
        }
    }
}

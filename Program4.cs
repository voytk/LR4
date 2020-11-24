using System;

namespace ConsoleApp12
{
    class ApplicationLicense
    {
        static void AllowTrial()
        {
            Console.WriteLine("Триальный режим");
        }
        static void AllowCommon()
        {
            Console.WriteLine("Бесплатная версия");
        }
        static void AllowPro()
        {
            Console.WriteLine("Платная версия");
        }
        static void Main(string[] args)
        {
            AllowTrial();
            AllowCommon();
            AllowPro();
            Console.ReadKey();
            int password = 1337;
            long pass2 = Convert.ToInt64(Console.ReadLine());
            do
            {
                Console.WriteLine("AllowTrial and AllowPro");
            }
            while (pass2 == password);




        }
    }
}

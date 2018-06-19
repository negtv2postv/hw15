using System;

namespace hw15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beto: Hey mijo do you want to go to the Dells for Father's day?");
            Console.ReadKey();

            Console.Write("Nano: Yeah papi, let's go said my son...[enter name] ");
            string babyName = Console.ReadLine();
            Console.WriteLine(babyName);
            Console.ReadKey();

            Console.WriteLine("Beto: What do you like to do at the Dells baby?");
            Console.ReadKey();

            Console.Write("Nano: I like to play in the water and...[enter activity] ");
            string swim = Console.ReadLine();
            Console.WriteLine(swim);
            Console.ReadKey();

            son Monkey = new son(babyName, 3, swim);

            Console.WriteLine("Beto: Ok mijo. Can you swim already?");
            Console.ReadKey();

            Console.WriteLine("Nano: Yeah daddy I'm a big boy now");
            Console.ReadKey();

            Console.WriteLine("Beto: Oh yeaaah baby, how old are you now?");
            Console.ReadKey();

            Console.Write("Nano: I am...[enter age] ");
            string babyAge = Console.ReadLine();
            Console.WriteLine(babyAge);
            Console.ReadKey();

            fathersDay beto = new fathersDay("beto", 21);

            beto.letsGo();
            Console.ReadKey();

        }
    }
}

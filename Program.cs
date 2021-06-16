using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz:");
            String name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            String surname = Console.ReadLine();

            Console.WriteLine("Merhaba"+ " " + name + " " + surname);
        }
    }
}

using System;

namespace ConsoleApp1
{
#nullable disable

    public class Foo
    {
        public DateTime Date { get; } = new(2020, 1, 1);

        public static Foo Get()
        {
            return null;
        }
    }

#nullable enable

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(new Foo()); // eliminate unused error
            
            var f = Foo.Get();

            if (f?.Date != default && f.Date > DateTime.Now)
            {
                Console.WriteLine("X");
            }
        }
    }
}
using System;

namespace InheritanceExercises
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            //1 Person
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //
            //try
            //{
            //    Child child = new Child(name, age);
            //    Console.WriteLine(child);
            //}
            //catch (ArgumentException ae)
            //{
            //    Console.WriteLine(ae.Message);
            //}

            //2 BookShop
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
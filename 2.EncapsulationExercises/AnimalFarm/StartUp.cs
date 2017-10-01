namespace P03_AnimalFarm
{
    using AnimalFarm.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string command;

            var pMInput = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            var prodMInput = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            foreach (var e in pMInput)
            {
                var tokens = e.Split('=');
                try
                {
                    persons.Add(new Person(tokens[0], double.Parse(tokens[1])));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }

            foreach (var e in prodMInput)
            {
                var tokens = e.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    products.Add(new Product(tokens[0], double.Parse(tokens[1])));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }

            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command.Split(' ');

                Person person = persons.Where(p => p.Name == tokens[0]).FirstOrDefault();
                Product product = products.Where(pr => pr.Name == tokens[1]).FirstOrDefault();

                if (person.Money < product.Coast)
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
                else
                {
                    persons.Where(p => p.Name == tokens[0]).FirstOrDefault().BuyProduct(product);
                    persons.Where(p => p.Name == tokens[0]).FirstOrDefault().Money -= product.Coast;
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
            }

            foreach (var e in persons)
            {
                if (e.Products.Count < 1)
                {
                    Console.WriteLine($"{e.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{e.Name} - {string.Join(", ", e.Products.Select(p => p.Name).ToList())}");
                }
            }

            //3. Chicken Exercises
            //Type chickenType = typeof(Chicken);
            //FieldInfo[] fields = chickenType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            //MethodInfo[] methods = chickenType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            //Debug.Assert(fields.Where(f => f.IsPrivate).Count() == 2);
            //Debug.Assert(methods.Where(m => m.IsPrivate).Count() == 1);
            //
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //
            //try
            //{
            //    Chicken chicken = new Chicken(name, age);
            //    Console.WriteLine(
            //        "Chicken {0} (age {1}) can produce {2} eggs per day.",
            //        chicken.Name,
            //        chicken.Age,
            //        chicken.GetProductPerDay());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // 1 & 2 Box Exercises
            //Type boxType = typeof(Box);
            //FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            //Console.WriteLine(fields.Count());
            //
            //double[] tokens = new double[3];
            //
            //Box box;
            //
            //for (int i = 0; i < 3; i++)
            //{
            //    tokens[i] = double.Parse(Console.ReadLine());
            //}
            //
            //try
            //{
            //    box = new Box(tokens[0], tokens[1], tokens[2]);
            //
            //    Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
            //    Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");
            //    Console.WriteLine($"Volume - {box.GetVolume():F2}");
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

        public void BuyProduct(Product product, Person person)
        {
        }
    }
}
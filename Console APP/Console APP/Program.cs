using System.Collections.Generic;

namespace ProjectWebDevelopmentBootcamp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write anythnig to turn it into capital letters: ");

            UpperCaseLetters();

            TuningCar tuningcar = new TuningCar();
            Gorgeous gorgeous = new Gorgeous();
            Numbers numbers = new Numbers();
            Characters characters = new Characters();

            tuningcar.Read();
            gorgeous.Read();

            Console.WriteLine("POLYMORPH EXAMPLE");

            NumbersCharacters[] symbols = { numbers, characters };
            foreach (NumbersCharacters symbol in symbols)
            {
                symbol.Polymorph();
            }

            double[] doubleArray = { 3.7, 4.4, 5.6 };
            string[] stringArray = { "4", "5", "7" };
            int[] intArray = { 2, 3, 4 };

            Console.WriteLine();
            Console.WriteLine("GENERIC EXAMPLE");
            Console.WriteLine();

            Generics(doubleArray);
            Generics(stringArray);
            Generics(intArray);

            Console.WriteLine();
            Console.WriteLine("Hope this is fine solution.");
            Console.ReadKey();

        }
        private static void UpperCaseLetters()
        {
            bool runAway = true;
            string fugitive;
            string answer;
            try
            {
                while (runAway == true)
                {
                    fugitive = Console.ReadLine();
                    fugitive = fugitive.ToUpper();

                    Console.WriteLine(fugitive);

                    Console.Write("DU wanna try again (Yes/No): ");
                    answer = Console.ReadLine();
                    answer = answer.ToUpper();

                    if (answer == "Yes")
                    {
                        runAway = true;
                    }
                    else
                    {
                        runAway = false;
                        Console.Clear();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please u wanna try again?");
            }
        }
        public static void Generics<Element>(Element[] array)
        {

            foreach (Element item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        interface Stars
        {
            void Read();

        }
        class TuningCar : Stars
        {
            public void Read()
            {
                Console.WriteLine("Every night on the sky i see lot\'s of stars");
                Thread.Sleep(4000);
                Console.Write("Name of the most important stars:");

                List<string> oldestStars = new List<string>();

                oldestStars.Add("North star, ");
                oldestStars.Add("Red dwarf, ");
                oldestStars.Add("Comet Ison, ");
                oldestStars.Add("Sun");

                foreach (string star in oldestStars)
                {
                    Console.Write(star);
                }

                Thread.Sleep(4000);
                Console.WriteLine();

            }
        }
        class Gorgeous : Stars
        {
            public void Read()
            {
                Console.WriteLine("U can also see some sparkling objects on the sky too");
                Thread.Sleep(2000);
                Console.Write("Some of that objects are not udentified yet ");
                string[] gorgeousStars = { "Comet on the south, ", "Moon near jupiter, ", "Sparkling milkyway " };

                for (int i = 0; i < gorgeousStars.Length; i++)
                {
                    Console.Write(gorgeousStars[i]);
                }

                Thread.Sleep(4000);
                Console.WriteLine();
                Console.WriteLine("Just...Press any button )))))!");
                Console.ReadKey();
                Console.Clear();
            }
        }
        class NumbersCharacters
        {
            public virtual void Polymorph()
            {

            }
        }
        class Numbers : NumbersCharacters
        {
            public override void Polymorph()
            {
                Console.WriteLine("55 66 77 890");
            }

        }
        class Characters : NumbersCharacters
        {
            public override void Polymorph()
            {
                Console.WriteLine("Red, Blue, White, Orange ");
            }
        }
    }
}


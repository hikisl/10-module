using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Введите первое число ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                int numberTwo = int.Parse(Console.ReadLine());


                INewCalc newCalc = new Calc();
                newCalc.Sum(number, numberTwo);

            }
            catch (FormatException)
            {

                Console.WriteLine("Некоректный ввод числа");
            }




        }
        public interface INewCalc
        {
            void Sum(int a, int b);
        }

        public class Calc : INewCalc
        {
            void INewCalc.Sum(int a, int b)
            {
                Console.WriteLine(a + b);
            }
        }



    }
}


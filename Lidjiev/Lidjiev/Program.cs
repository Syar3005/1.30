 using System;

    namespace Lidjiev
    { 
      class MainClass
      {
        public static void Main()
        {
            Double x, y, z;
            Console.WriteLine("Введите значение x");
            x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Double.Parse(Console.ReadLine());
            z = Math.Pow(x, 3) - 2.5 * x * y + Math.Pow(1.78, 2) - 2.5 *y + 1;
            Console.WriteLine("Ответ: {0}" ,z);
        }
      }
    }




 

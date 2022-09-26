 using System;

    namespace Lidjiev
    { 
      class MainClass2
      {
        public static void Main2()
        {
            Double a, b, x;
            Console.WriteLine("Введите значение a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            b = Double.Parse(Console.ReadLine());
            x = 3.56 * a + Math.Pow (b,3) - 5.8*(Math.Pow(b,2) + 3.8*a - 1.5);
            Console.WriteLine("Ответ: {0}" ,x);
        }
      }
    }




 

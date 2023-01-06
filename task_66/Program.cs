using System;

namespace task_66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N и нажмите enter:");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите M и нажмите enter:");
            var m = int.Parse(Console.ReadLine());
            if(n>=m)
            {
                Console.WriteLine("N должна быть меньше M");
            }
            else
            {
                var sum = 0;
                Console.WriteLine(string.Format("сумма = {0}", RecursionSum(sum, n, m)));
            }
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }

        static int RecursionSum(int sum, int n, int m)
        {
            if(n > m)
                return sum;
            return RecursionSum(sum + n, ++n, m);
        }
    }
}

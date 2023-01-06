using System;

namespace task_68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N и нажмите enter:");
            var n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите M и нажмите enter:");
            var m = uint.Parse(Console.ReadLine());
            if(n< 0 || m < 0)
            {
                Console.WriteLine("N и M должны быть больше или равно 0");
            }
            else
            {
                Console.WriteLine(string.Format("Число Аккерамана = {0}", Ackerman(n, m)));
            }
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }

        static uint Ackerman(uint n, uint m)
        {
            if(n == 0)
                return m + 1;
            else if(m == 0)
                return Ackerman(n - 1, 1);
            else
                return Ackerman(n - 1, Ackerman(n, m - 1));
        }
    }
}

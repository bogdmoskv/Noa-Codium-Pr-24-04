using System;
using System.Collections.Generic;

namespace BadCodeTest
{
    class Program
    {
        // Ошибка 1: Статическое поле с непонятным названием
        static string s = "Hello, World!";

        static void Main(string[] args)
        {
            DoStuff();
        }

        static void DoStuff()
        {
            try
            {
                // Ошибка 2: Хардкод и непонятные переменные
                var a = 10;
                var b = 0;

                // Ошибка 3: Потенциальный DivideByZeroException без проверки
                var res = a / b;

                // Ошибка 4: Глубокая вложенность (Arrow code)
                if (a > 0)
                {
                    if (s != null)
                    {
                        if (s.Length > 0)
                        {
                            Console.WriteLine(s + " Result: " + res);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ошибка 5: Пустой catch или подавление ошибки без логирования
                // Это "красная тряпка" для любого лида
            }
        }

        // Ошибка 6: Неиспользуемый метод, который ничего не делает
        private void UnusedMethod(int x, string y, double z)
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
        }
    }
}
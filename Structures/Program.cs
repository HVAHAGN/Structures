using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    // Структуры.

    // В структурах нельзя инициализировать поля непосредственно в месте создания.
    struct MyStruct
    {
        public int field;
    }

    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа, без вызова конструктора.
            MyStruct instance;

            instance.field = 1; // Закомментировать.

            // Попытка вывода значения неинициализированного поля приведет к ошибке.
            Console.WriteLine(instance.field);

            // Delay.
            Console.ReadKey();
        }
    }
}

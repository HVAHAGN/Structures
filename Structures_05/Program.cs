using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_05
{
    // Структуры.

    // Структуры могут содержать статические члены.

    // Статические структуры недопустимы.
    struct MyStruct
    {
        public static int Field
        {
            get;
            set;
        }

        public static void Show()
        {
            Console.WriteLine(Field);
        }
    }

    class Program
    {
        static void Main()
        {
            // Инициализация статических полей необязательна.
            //MyStruct.Field = 1;

            MyStruct.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}


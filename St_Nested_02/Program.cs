using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St_Nested_02
{
    // Nested structures.

    // Структуры могут содержать вложенные классы.
    struct MyStruct
    {
        public class Nested
        {
            public void Method()
            {
                Console.WriteLine("Nested");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct.Nested instance = new MyStruct.Nested();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}

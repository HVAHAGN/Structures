using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St_Inheritance_03
{
    // Структуры. Наследование.

    // От структур нельзя наследоваться.
    struct MyStruct
    {
        // Структуры не могут иметь protected членов.
        //protected int field;
    }

    class MyClass //: MyStruct
    {
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("От структур нельзя наследоваться.");

            // Delay.
            Console.ReadKey();
        }
    }
}
